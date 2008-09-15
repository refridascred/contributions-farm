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

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long SortStatsNotes(long limit, long floor)
        {
            long next = limit - floor;
            if (62 >= (next << 3))
            {
                return 8;
            }
            else
            {
                if ((next + limit) != (next + (-129)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
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
