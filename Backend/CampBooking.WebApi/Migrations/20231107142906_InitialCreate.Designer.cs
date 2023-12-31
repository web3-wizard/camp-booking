﻿// <auto-generated />
using System;
using CampBooking.DAL.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CampBooking.WebApi.Migrations
{
    [DbContext(typeof(CampDBContext))]
    [Migration("20231107142906_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CampBooking.DAL.DbModel.BookingDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<Guid>("CampId")
                        .HasColumnType("char(36)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("longtext");

                    b.Property<string>("CheckIn")
                        .HasColumnType("longtext");

                    b.Property<string>("CheckOut")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<int>("Nights")
                        .HasColumnType("int");

                    b.Property<int>("Persons")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("CampBooking.DAL.DbModel.Camp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Camps");
                });

            modelBuilder.Entity("CampBooking.DAL.DbModel.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CampId")
                        .HasColumnType("char(36)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("longtext");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("longtext");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("CampBooking.DAL.DbModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@gmail.com",
                            IsAdmin = true,
                            Name = "Admin",
                            Password = "admin@123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "rahul@gmail.com",
                            IsAdmin = false,
                            Name = "Rahul",
                            Password = "rahul@123"
                        },
                        new
                        {
                            Id = 3,
                            Email = "admin@campbooking.com",
                            IsAdmin = true,
                            Name = "Admin App",
                            Password = "admin@123"
                        },
                        new
                        {
                            Id = 4,
                            Email = "test@gmail.com",
                            IsAdmin = false,
                            Name = "Test User",
                            Password = "test@123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
