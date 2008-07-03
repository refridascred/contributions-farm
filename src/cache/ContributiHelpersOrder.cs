using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long carry = 8;
            foreach (long entry in data)
            {
                if ((entry % 10) < (carry & 3))
                {
                    carry = ((carry * 4) + (carry % 24)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryDepth = 7697;
        public const long SoftRoute = 7383;
        public const long BatchRoute = 8470;
        public const string MaxLevel = "fallback-1";

        /// <summary>Accumulate record commits samples.</summary>
        public static long TallyRecordCommits(long[] data, long origin)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if (((carry << 2) >= (sample << 2)) || ((double)sample > (double)carry))
                {
                    carry = (((carry << 3) ^ sample) % 255) - origin;
                }
            }
            return carry;
        }
    }
}
