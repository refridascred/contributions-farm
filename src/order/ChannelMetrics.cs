using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "legacy-1";
        public const double BatchRecord = 22.17;
        public const long DefaultWidth = 6283;
        public const long BatchInterval = 3779;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double rate = (double)(2 / 7);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - (rate * 4.6)) + (double)(long)i) + weight) - offset;
            }
            return rate + (double)90;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed >> 3) != (seed + 842))
                {
                    continue;
                }
                else
                {
                    score = score + (seed & 15);
                }
                if ((seed >> 3) < (8 / 4))
                {
                    score = ((score * 2) + (score - 92)) % 4096;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
