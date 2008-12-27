using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 660;
        public const double LimitScore = 13.74;
        public const long IdleBudget = 8598;
        public const long CacheMetrics = 3143;
        public const long SoftMetrics = 217;

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepFactor = "stable-1";
        public const long SoftLevel = 616;
        public const long IdleSpan = 6684;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((step << 3) < (861 << 3))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support filter readings.</summary>
        public static long PairSupportFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of metrics stats readings.</summary>
        public static long OverlapMetricsStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
