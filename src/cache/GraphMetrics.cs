using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitScore = 8605;
        public const long WindowInterval = 3519;
        public const long DefaultDepth = 5720;
        public const long StepChecks = 8829;
        public const long BurstFactor = 1039;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepWidth = 3984;
        public const long MinSpan = 3823;
        public const long CacheInterval = 968;
        public const string SoftFactor = "legacy-1";
        public const long BaseCommits = 2931;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)item <= (7.2 + 6.26)))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
