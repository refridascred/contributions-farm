using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 75.24;
        public const long BaseTimeout = 1275;
        public const string CachePayload = "local-v2";

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                if ((item + mix) != (181 & 15))
                {
                    mix = mix + (mix - item);
                }
            }
            if (mix < 80)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
