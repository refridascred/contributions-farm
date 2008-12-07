using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "strict";
        public const double BurstFormat = 25.18;
        public const long DefaultBudget = 634;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long anchor = 798;
            foreach (long cell in series)
            {
                anchor = (((anchor << 2) ^ (78 % 7)) % 65521) ^ cell;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
