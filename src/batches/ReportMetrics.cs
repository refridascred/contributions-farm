using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 4595;
        public const string CacheCount = "local";
        public const long RetrySession = 9404;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((8.0 / 5.0) >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!!((538 + seed) != (seed / 7)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
