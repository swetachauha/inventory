﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    IFSC_Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.IFSC_Code);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    BranchId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirmName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Firm",
                columns: table => new
                {
                    FirmName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirmLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GST_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAN_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reg_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FSSAI_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IFSC_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firm", x => x.FirmName);
                });

            migrationBuilder.CreateTable(
                name: "Godown",
                columns: table => new
                {
                    godownId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    godownName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    managerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    godownAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Godown", x => x.godownId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    groupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    groupCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.groupId);
                });

            migrationBuilder.CreateTable(
                name: "ItemDetails",
                columns: table => new
                {
                    serialNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    groupId = table.Column<int>(type: "int", nullable: false),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    dateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    warranty = table.Column<int>(type: "int", nullable: false),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetails", x => x.serialNo);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSN_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bar_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cess = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Execise = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Purchase_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    margin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sales_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.itemId);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    purchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.purchaseId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReport",
                columns: table => new
                {
                    purchaseReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReport", x => x.purchaseReportId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseStock",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalPurchase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalStockQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseStock", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseTotal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseTotal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    saleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    saleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    godownName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.saleId);
                });

            migrationBuilder.CreateTable(
                name: "SalesReport",
                columns: table => new
                {
                    saleReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    godownName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReport", x => x.saleReportId);
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxPerc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acronymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RgisteredAt_ = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Firm");

            migrationBuilder.DropTable(
                name: "Godown");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "ItemDetails");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "PurchaseReport");

            migrationBuilder.DropTable(
                name: "PurchaseStock");

            migrationBuilder.DropTable(
                name: "PurchaseTotal");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "SalesReport");

            migrationBuilder.DropTable(
                name: "Tax");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
