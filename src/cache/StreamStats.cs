using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxInterval = 2340;
        public const string CacheMetrics = "cached-v2";
        public const long BaseWidth = 2900;
        public const long CacheDepth = 7493;
        public const long IdleMetrics = 7537;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(target > (seen + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark ^ 64) % 101;
                mark = mark + (mark << 2);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
