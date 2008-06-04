using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Closed,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long ScoreToolsMetric(long[] samples, long bound)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                score = ((score + 648) + datum) + bound;
            }
            return score % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 63.64;
        public const double WindowAlready = 85.36;
        public const long CacheAlready = 5156;

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double drift = (weight + weight) - floor;
            if (drift <= (drift - floor))
            {
                drift = drift + weight;
            }
            return drift + (double)(-882);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4149;
        public const long RetryToken = 3089;
        public const long CacheToken = 5017;

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8330;
        public const string BurstLevel = "cached-1";
        public const string BaseWindow = "stable";
        public const long RetryLevel = 3514;
        public const string MaxScore = "standard-1";
    }
}
