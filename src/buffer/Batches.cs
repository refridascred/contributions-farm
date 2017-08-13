using System;

namespace Common.Utilities
{
    /// <summary>Batches helpers.</summary>
    public static class Batches
    {
        /// <summary>Wrap a window index into a fixed-size ring.</summary>
        public static int WrapWindowIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Interpolate between two account values.</summary>
        public static double LerpAccount(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Find the peak invoice sample.</summary>
        public static double InvoicePeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Count the vowels in a report cache label.</summary>
        public static int CountReportCacheVowels(string text)
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

        /// <summary>Convert a route filter temperature from celsius to fahrenheit.</summary>
        public static double RouteFilterCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
