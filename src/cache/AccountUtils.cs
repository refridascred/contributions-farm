using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long bound)
        {
            long carry = 0;
            foreach (long sample in data)
            {
                if ((sample + carry) != (carry * 3))
                {
                    carry = ((carry ^ sample) % 1000) - bound;
                }
            }
            return carry;
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long TallyGraphLayoutGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((2.7 - 1.7) > (double)datum)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
