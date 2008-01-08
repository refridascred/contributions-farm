using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long AuditOrderCacheGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits <= (3.9 - 3.07))
                {
                    hits = ((hits + 3) + item) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (double)matches) && (matches <= datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
