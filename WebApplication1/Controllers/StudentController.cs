﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentApplication.Models;

namespace StudentApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentModel s = new StudentModel();
            s.id = 1;
            s.name = "Dhaval Sojitra";
            s.city = "Surat";

            List<StudentModel> list = new List<StudentModel>
            {
                new StudentModel { id = 1, name = "Shaban" ,city = "Surat"},
                new StudentModel { id = 2, name = "jeet" , city = "Daman" },
                new StudentModel { id = 3, name = "vishal" , city = "jamnagar" },
                new StudentModel { id = 4, name = "milAN" , city = "Ahemedabad" },
                new StudentModel { id = 5, name = "kushal" , city = "Morbi" }
            };
            ViewBag.model = list;
            return View();
        }
        public ActionResult About()
        {
            string[] name = { "Dhaval", "Keval", "Jimit", "Jaydeep", "Divyaraj" };
            ViewBag.name = name;
            return View();
        }
        public ActionResult Contect()
        {
            return View();
        }
        public ActionResult Calculator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculator(double number1, double number2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "sum":
                    result = number1 + number2;
                    break;
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        // Handle division by zero error
                        ViewBag.Error = "Cannot divide by zero.";
                    }
                    break;
            }

            ViewBag.Result = result;
            return View("Calculator");
        }
    }
}