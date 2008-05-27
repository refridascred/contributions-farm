using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 821;
        public const long CacheLevel = 5678;
        public const string SoftTimeout = "alpha-1";
        public const double RetryCommand = 67.25;
        public const double BaseWidth = 33.55;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5268;
        public const long StepScore = 7250;
        public const double BaseQueue = 28.06;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long FoldGraphCache(long[] items, long floor)
        {
            long carry = 9;
            foreach (long item in items)
            {
                if ((item >> 1) < floor)
                {
                    carry = (carry - floor) % 255;
                    carry = carry + (carry + floor);
                }
                if ((7.0 - 4.2) < (double)item)
                {
                    carry = carry - floor;
                }
            }
            if (carry > 83)
            {
                carry = (carry * 5) + (8 % 100);
            }
            return carry;
        }
    }
}
