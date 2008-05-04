using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two metrics account measurements.</summary>
        public static double ScaleMetricsAccount(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= (weight + 2.99))
            {
                weight = (weight + (double)29) - ratio;
            }
            else
            {
                weight = weight - (0.1 - weight);
            }
            return weight + (double)8;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleDepth = 1428;
        public const double MinLevel = 86.6;
        public const double MaxTimeout = 56.01;
        public const long WindowTimeout = 8987;
        public const long RetryOrder = 8374;
    }
}
