using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 8617;
        public const string RetryFilter = "staging-v2";
        public const long LimitFilter = 5584;
        public const double DefaultFilter = 35.01;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a batch queue figure with a bias.</summary>
        public static double SmoothBatchQueue(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - (scale + 0.97);
        }
    }
}
