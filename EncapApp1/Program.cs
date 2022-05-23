//Övning 3.1

using System;

class Person {
    private int age;
    private string fName;
    private string lName;
    private int height;
    private int weight;

    public int Age
    {
        get { return age; }

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Age must be above 0");

            age = value; }
    }

    public string FName
    {
        get { return fName; }

        set
        {
            if (value.Length < 2 || value.Length > 10)
                throw new ArgumentOutOfRangeException("First name must be admitted and no less than two or more than ten characters");
            fName = value; }
    }
    public string LName
    {
        get { return lName; }

        set
        {
            if (value.Length < 3 || value.Length > 15)
                throw new ArgumentOutOfRangeException("Last name must be admitted and no less than three or more than fifteen characters");
            lName = value;
        }
        
        }

    public int Height
    {
        get { return height; } set { height = value; }
    }

    public int Weight
    {
        get { return weight; } set { weight = value; }

    }
}

class PersonHandler
{


    public void SetAge(Person pers, int age)
    {
        pers.Age = age;

    }

    public Person CreatePerson(int age, string fname, string lname, double height, double weight)
    {

        return "Age =  " + age + "FName = " + fname + "LName" + lname + "Height" + height + "weight " + weight;
    }

    static void Main(string[] args)
    {
        Person person = new Person();
        person.Age = 30;
        person.FName = "Lisa";
        person.LName = "Pisa";

        PersonHandler pers = new PersonHandler();
        pers.CreatePerson(20,"Lisa","Pisa", 167, 50);
    }   

}
