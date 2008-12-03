using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseSize = "latest";
        public const long DefaultFormat = 7528;
        public const long MinDepth = 3559;
        public const long IdleFormat = 7674;
        public const double BurstFormat = 90.19;

        /// <summary>Blend two counter format measurements.</summary>
        public static double BlendCounterFormat(double weight, double bias)
        {
            double mean = weight;
            if (mean < bias)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
