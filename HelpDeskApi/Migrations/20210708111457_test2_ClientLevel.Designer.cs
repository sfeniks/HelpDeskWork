﻿// <auto-generated />
using System;
using HelpDeskApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HelpDeskApi.Migrations
{
    [DbContext(typeof(HelpDeskDbContext))]
    [Migration("20210708111457_test2_ClientLevel")]
    partial class test2_ClientLevel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelpDeskApi.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Contrac")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ServiceMenager")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.EnginerLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("EnginerLines");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Contrac")
                        .HasColumnType("bit");

                    b.Property<string>("IdEnginerLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressID")
                        .IsUnique();

                    b.HasIndex("ClientId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProblemCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("UnderService")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProblemCategoryId");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProblemPlaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProblemPlaceId");

                    b.ToTable("ProblemsCategory");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.ToTable("ProblemsPlace");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemSolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProblemId")
                        .HasColumnType("int");

                    b.Property<string>("Step1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Step2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Step3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProblemId");

                    b.ToTable("ProblemsSolution");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("WorkStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.EnginerLine", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Location", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.Address", "Address")
                        .WithOne("Location")
                        .HasForeignKey("HelpDeskApi.Entities.Location", "AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HelpDeskApi.Entities.Client", "Client")
                        .WithMany("Locations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Problem", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.ProblemCategory", "ProblemCategory")
                        .WithMany("Problem")
                        .HasForeignKey("ProblemCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProblemCategory");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemCategory", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.ProblemPlace", "ProblemPlace")
                        .WithMany("ProblemsCategory")
                        .HasForeignKey("ProblemPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProblemPlace");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemPlace", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.Client", "Client")
                        .WithMany("ProblemPlaces")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemSolution", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.Problem", "Problem")
                        .WithMany("ProblemSolution")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Problem");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.User", b =>
                {
                    b.HasOne("HelpDeskApi.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Address", b =>
                {
                    b.Navigation("Location");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Client", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("ProblemPlaces");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.Problem", b =>
                {
                    b.Navigation("ProblemSolution");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemCategory", b =>
                {
                    b.Navigation("Problem");
                });

            modelBuilder.Entity("HelpDeskApi.Entities.ProblemPlace", b =>
                {
                    b.Navigation("ProblemsCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
