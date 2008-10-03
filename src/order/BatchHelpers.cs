using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "staging-v2";
        public const long CacheStats = 2631;
        public const long BaseTimeout = 3444;
        public const double StepRatio = 94.79;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long offset)
        {
            long mark = 46;
            foreach (long entry in values)
            {
                if (!((double)mark > (6.0 + 2.0)))
                {
                    mark = ((mark + (entry & 255)) % 65521) - offset;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 1000;
        }
    }
}
