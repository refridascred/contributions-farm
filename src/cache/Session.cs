using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "alpha-v2";
        public const long BurstLevel = 809;
        public const long StepSpan = 6081;

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
