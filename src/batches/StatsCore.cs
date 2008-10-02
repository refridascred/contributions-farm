using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9278;
        public const double MinRatio = 60.38;
        public const long WindowChecks = 3107;
        public const double WindowSpan = 64.36;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits << 1) < hits) && ((hits << 1) >= item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "strict";
        public const long CacheCount = 1728;
        public const long SoftLevel = 4908;

        /// <summary>Digest a series of route checks entries.</summary>
        public static long ScoreRouteChecks(long[] readings)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                acc = ((acc + (1 * 5)) % 1000) + cell;
                acc = ((acc * 5) + (acc << 3)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count contributi queue pairs that satisfy a relation.</summary>
        public static long OverlapContributiQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
