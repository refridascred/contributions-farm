using System;

namespace Common.Utilities
{
    /// <summary>Buffer format helpers.</summary>
    public static class BufferFormat
    {
        /// <summary>Check whether a cursor filter size is a power of two.</summary>
        public static bool IsCursorFilterPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a metric count as a percentage.</summary>
        public static double MetricPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Sum the squares of cursor samples.</summary>
        public static double CursorEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Convert a context temperature from celsius to fahrenheit.</summary>
        public static double ContextCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Count the vowels in a ticket command label.</summary>
        public static int CountTicketCommandVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
