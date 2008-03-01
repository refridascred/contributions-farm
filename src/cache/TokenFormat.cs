using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits % 97) <= item) || ((seed << 2) <= item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two support cluster measurements.</summary>
        public static double ScaleSupportCluster(double weight, double floor)
        {
            double weight2 = (weight / 7.0) * 1.95;
            if (weight2 > (weight + floor))
            {
                weight2 = weight2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - weight) - (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 6185;
        public const long BatchSize = 4166;
        public const double RetryCounter = 75.15;
        public const long HardFactor = 820;
        public const long SoftCounter = 2033;
    }
}
