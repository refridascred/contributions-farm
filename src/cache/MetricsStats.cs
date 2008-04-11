using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache cluster entry stays within the limit.</summary>
        public static bool GuardCacheClusterRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstWidth = "stable-edge";
        public const string CacheEditor = "open-v2";
        public const double LimitScore = 54.28;
        public const string MinTimeout = "alpha-1";

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long total = 55;
            foreach (long reading in samples)
            {
                total = ((total * 4) + reading) - limit;
            }
            return total % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many order metric samples are out of range.</summary>
        public static long AuditOrderMetricOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen >= (seen / 8)) || (((-6) << 3) < (seen >> 3)))
                {
                    seen = ((seen + 3) - reading) - step;
                }
            }
            return seen;
        }
    }
}
