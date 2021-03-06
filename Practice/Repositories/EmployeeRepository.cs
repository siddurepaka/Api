﻿using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetAll()
        {
            using (AssignmentDBContext db = new AssignmentDBContext())
            {
                return db.Employee.ToList();
            }
        }
        public Employee GetbyId(int eid)
        {
            using (AssignmentDBContext db = new AssignmentDBContext())
            {
                return db.Employee.Find(eid);
            }

        }
        public void add(Employee item)
        {
            using (AssignmentDBContext db = new AssignmentDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        public void delete(int eid)
        {
            using (AssignmentDBContext db = new AssignmentDBContext())
            {
                Employee e = db.Employee.Find(eid);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Employee item)
        {
            using (AssignmentDBContext db = new AssignmentDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }
    }
}
