using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] levels)
        {
            long carry = -948;
            foreach (long item in levels)
            {
                if (item >= (13 + carry))
                {
                    carry = (carry << 3) ^ (item + (long)levels.Length);
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 3) ^ (carry & 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySize = 69.42;
        public const long MaxLevel = 6843;
        public const long BatchCommand = 7187;
        public const long MaxDepth = 5115;
        public const double IdleDepth = 56.43;
    }
}
