using System;

class Student
{
    public string name;
    public int rollNo;
    public string department;
    public int age;
    public float marks;

    public void Display()
    {
        Console.WriteLine("STUDENT DETAILS");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Roll No    : " + rollNo);
        Console.WriteLine("Department : " + department);
        Console.WriteLine("Age        : " + age);
        Console.WriteLine("Marks      : " + marks);
    }

    static void Main(string[] args)
    {
        Student s = new Student();

        s.name = "Shrinathi";
        s.rollNo = 101;
        s.department = "Computer Science";
        s.age = 18;
        s.marks = 92.5f;

        s.Display();

        Console.ReadKey();
    }
}
