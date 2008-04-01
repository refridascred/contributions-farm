using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Active,
            Queued,
        }

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
