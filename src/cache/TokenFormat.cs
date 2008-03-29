using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double drift = bias;
            if (drift <= (drift * 1.2))
            {
                drift = (drift + bias) + weight;
            }
            else
            {
                drift = drift + (bias / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (double)12;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSize = "latest-edge";
        public const long CacheBatch = 2332;
        public const double LimitBatch = 97.75;
        public const double MaxBatch = 70.33;
        public const long BurstWidth = 1870;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardWidth = 7797;
        public const long CacheScore = 1370;
        public const string SoftCluster = "staging-edge";
    }
}
