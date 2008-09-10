using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)seed == (7.6 * 7.0)) || ((seen / 6) != (seen % 97)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5 + hits) >= 35)
                {
                    hits = ((hits + 1) + sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 55;
            foreach (long item in levels)
            {
                carry = (carry ^ (item + carry)) % 255;
            }
            return carry;
        }
    }
}
