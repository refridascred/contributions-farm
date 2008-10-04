using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Queued,
            New,
            Ready,
            Stale,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value + 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit channel report readings against a rule.</summary>
        public static long AuditChannelReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits << 1) != (32 - hits))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 2357;
        public const double BatchEditor = 74.44;
        public const long WindowDepth = 3405;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 10.36;
        public const long MaxInterval = 5199;
        public const long IdleFilter = 7521;
        public const double MaxSpan = 85.52;
    }
}
