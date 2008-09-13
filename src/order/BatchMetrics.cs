using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double drift = weight + bias;
            if (drift <= (weight + drift))
            {
                drift = drift - (double)15;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)70;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double rate = (double)(725 - 0);
            return ((rate - rate) + bias) + bias2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 47.96;
        public const long RetryFactor = 5408;
        public const long CacheCluster = 2074;
        public const string IdleInterval = "stable-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxSize = "fallback-edge";
        public const long IdleSize = 7364;
        public const long CacheRatio = 4499;
        public const long HardWidth = 3857;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 2587;
        public const long SoftBudget = 7613;
        public const long MaxMetric = 1615;

        /// <summary>Combine buffer metric values into a single score.</summary>
        public static long DigestBufferMetric(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = (state - (state + 1)) % 101;
                state = (state - (item - state)) % 1000;
            }
            return state % 65521;
        }
    }
}
