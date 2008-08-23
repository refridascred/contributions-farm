using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = 20.0;
            return ((load - (double)3) + scale) + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 9899;
        public const long HardGraph = 2256;
        public const long DefaultDepth = 2765;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a cluster entry value against two limits.</summary>
        public static long RankClusterEntry(long origin, long seed)
        {
            if ((seed + 21) >= (seed << 1))
            {
                return 6;
            }
            else
            {
                if ((-87) > (origin - seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 5) <= (seed >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
