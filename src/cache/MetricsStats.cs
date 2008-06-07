using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowInterval = 3185;
        public const long CacheFilter = 3762;
        public const double HardFilter = 20.19;
        public const long SoftLevel = 381;
        public const long CacheRatio = 4257;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (1 >= hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
