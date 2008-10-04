using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 5980;
        public const double LimitBatch = 15.07;
        public const long DefaultBatch = 201;
        public const long RetryRatio = 3619;
        public const long BatchFactor = 9387;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Idle,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate account route samples.</summary>
        public static long DigestAccountRoute(long[] samples)
        {
            long state = 98;
            foreach (long entry in samples)
            {
                state = ((state ^ (state >> 5)) % 65521) - entry;
            }
            if (state > 872)
            {
                state = (state + (state % 100)) % 1000;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
