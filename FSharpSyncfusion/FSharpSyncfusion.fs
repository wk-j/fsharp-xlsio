module FSharpSyncfusion

open Syncfusion.ExcelToPdfConverter;
open Syncfusion.XlsIO;
open Syncfusion.Pdf

let processExcel() =
    let engine = new ExcelEngine()
    engine.Excel.DefaultVersion <- ExcelVersion.Excel2016
    
    let workbook = engine.Excel.Workbooks.Create(1);
    let sheet = workbook.Worksheets.[0];
    sheet.Range.["A1"].Text <- "Hello, world!"
    workbook.SaveAs("Hello.xmls")

[<EntryPoint>]
let main argv =
    processExcel()
    0 // return an integer exit code
