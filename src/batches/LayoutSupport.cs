using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double mean = rate / 8.0;
            return (mean - (double)4) + offset;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (67 % 10);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultSize = 26.53;
        public const double SoftSize = 1.82;
        public const double RetrySize = 45.71;
        public const long CacheLevel = 1014;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9345;
        public const long SoftEditor = 1570;
        public const long LimitDepth = 5683;
        public const double MaxEditor = 25.85;
        public const long BurstFactor = 9543;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Failed,
            Paused,
            Dropped,
        }
    }
}
