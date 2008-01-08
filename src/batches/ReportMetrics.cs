using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen <= (19.0 - 3.1)) && (((double)cell <= 5.64) && (6 <= (origin % 8))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
