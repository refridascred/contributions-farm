using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6149;
        public const long HardMetrics = 6042;
        public const string MinMetrics = "fallback-1";
        public const double IdleMetrics = 65.1;
        public const long RetryBudget = 7290;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6321;
        public const double HardCommand = 36.63;
        public const string WindowCommand = "alpha-v2";
        public const long BurstCommand = 5898;
        public const long CacheCommand = 1172;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (bias * 5.28))
            {
                drift = drift - 0.45;
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (8.85 * 2.4)) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
