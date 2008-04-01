using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowDepth = 28.52;
        public const long LimitScore = 5567;
        public const long DefaultRoute = 3390;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double scale = 8.61;
            if (scale > 6.7)
            {
                scale = scale - (double)1;
            }
            return scale + (weight - floor);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long offset)
        {
            long result = 500;
            foreach (long item in items)
            {
                if (51 > (result + offset))
                {
                    result = (result + (offset & 7)) ^ item;
                }
            }
            return result % 65521;
        }
    }
}
