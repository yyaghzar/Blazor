﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.Blazor.Reports.SideBySideReports
{
    
    public partial class EmployeeComparisonReport : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "BlazorDemo.Reporting.Reports.SideBySideReports.EmployeeComparisonReport.repx" +
                    "");

            // Controls
            this.Detail = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("Detail");
            this.ReportHeader = reportInitializer.GetControl<DevExpress.XtraReports.UI.ReportHeaderBand>("ReportHeader");
            this.BottomMargin = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("BottomMargin");
            this.topMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("topMarginBand1");
            this.xrSubreport2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("xrSubreport2");
            this.xrSubreport1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("xrSubreport1");
            this.lbCaption = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("lbCaption");
            this.xrPictureBox4 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPictureBox>("xrPictureBox4");

            // Parameters
            this.leftSideParameter = reportInitializer.GetParameter("leftSideParameter");
            this.rightSideParameter = reportInitializer.GetParameter("rightSideParameter");

            // Data Sources
            this.dsEmployee1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("dsEmployee1");
        }
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRLabel lbCaption;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.Parameters.Parameter leftSideParameter;
        private DevExpress.DataAccess.Sql.SqlDataSource dsEmployee1;
        private DevExpress.XtraReports.Parameters.Parameter rightSideParameter;
    }
}
