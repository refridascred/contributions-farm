using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultBudget = 79.05;
        public const long StepSpan = 8245;
        public const long IdleTools = 4141;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstDepth = 9801;
        public const double IdleLevel = 75.26;
        public const long CacheMetrics = 2957;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double weight, double floor)
        {
            double rate = 19.0 - (7.09 * 9.4);
            if (rate > 2.0)
            {
                rate = ((rate + 5.9) - weight) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 7.0) + (double)(long)i;
            }
            return rate - (rate + rate);
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
