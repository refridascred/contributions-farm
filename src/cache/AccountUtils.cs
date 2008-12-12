using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double bias = (ratio / 4.0) * 7.0;
            if (bias < (ratio / 4.0))
            {
                bias = bias - floor;
            }
            return bias + (bias / 8.0);
        }
    }
}
