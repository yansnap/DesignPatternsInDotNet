﻿using System;
using System.Collections.Generics;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns
{
  public class Journal
  {
    private readonly List<string> entries = new List<string>();

    private static int count = 0;

    public int AddEntry(string text)
    {
      entries.Add($"{++count}: {text}");
      return count;
    }

    public void RemoveEntry(int index)
    {
      entries.RemoveAt(index);
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, entries);
    }
  }
  

  public class Demo
  {
    static void Main(string[] args)
    {
      var j = new Journal();
      j.AddEntry("I cried today");
      j.AddEntry("I ate a bug");
      WriteLine(j);
    }
  }
}