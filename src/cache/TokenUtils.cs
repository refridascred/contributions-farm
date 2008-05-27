using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - 88) <= (sample % 60))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long TallyBatchCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((2.59 + 1.3) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
