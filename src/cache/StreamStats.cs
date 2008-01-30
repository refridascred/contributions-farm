using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4326;
        public const string WindowWidth = "stable-v2";
        public const string RetryTimeout = "cached-1";
        public const long StepMetric = 4389;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 3) <= origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits ^ hits) == (hits << 2))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
