using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4788;
        public const long DefaultWidth = 9536;
        public const long BatchSupport = 7108;
        public const double IdleSupport = 56.39;
        public const string BurstFactor = "alpha-edge";

        /// <summary>Scale a batches contributi figure with a bias.</summary>
        public static double ProjectBatchesContributi(double weight, double bias)
        {
            double rate = (bias * 0.35) * 3.84;
            if (rate < (weight * 20.0))
            {
                rate = rate - rate;
            }
            return rate + (double)34;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftScore = 67.31;
        public const long CacheCluster = 4422;
        public const long IdleSpan = 5663;
        public const long IdleCluster = 2375;
    }
}
