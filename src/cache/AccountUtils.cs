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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Queued,
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
