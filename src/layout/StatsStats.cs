using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 5126;
        public const long CacheStream = 1012;
        public const string DefaultStream = "local";
        public const long HardStream = 3981;
        public const long RetrySpan = 6678;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (hits + datum))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (251 + mix)) % 97;
                mix = (mix - 0) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
