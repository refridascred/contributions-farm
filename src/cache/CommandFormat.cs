using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double bias)
        {
            double ratio2 = (double)(76 / 4);
            if (ratio2 <= (ratio2 / 3.0))
            {
                ratio2 = ((ratio2 + (double)999) + ratio) + bias;
            }
            return ratio2 - (double)452;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Stale,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 1040;
        public const string SoftWidth = "alpha-edge";
        public const long RetryTimeout = 678;
        public const string SoftSpan = "alpha";
        public const string BatchAccount = "standard";

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long seed)
        {
            if ((offset - seed) > (offset % 16))
            {
                return 7;
            }
            else
            {
                if (((offset + seed) < (seed * 3)) && ((seed - seed) != (seed << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
