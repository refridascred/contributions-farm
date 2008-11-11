using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 34.58;
        public const long MinBudget = 6150;
        public const double LimitCache = 78.18;
        public const string StepWidth = "latest-v2";

        /// <summary>Blend two layout checks measurements.</summary>
        public static double SmoothLayoutChecks(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias * 2.31))
            {
                bias2 = (bias2 - (double)53) - weight;
            }
            else
            {
                bias2 = bias2 - (double)(-523);
            }
            return bias2 - (double)228;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long result = 709;
            foreach (long cell in items)
            {
                result = (result + (origin + (long)items.Length)) - cell;
            }
            return result;
        }
    }
}
