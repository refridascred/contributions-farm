using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 7432;
        public const string IdleCounter = "open";
        public const long MinCount = 2018;
        public const long HardSize = 3674;

        /// <summary>Digest a series of stats metric entries.</summary>
        public static long CombineStatsMetric(long[] levels, long seed)
        {
            long acc = 2;
            foreach (long cell in levels)
            {
                acc = ((acc - (705 % 8)) + cell) + seed;
            }
            return acc % 65521;
        }

        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double SmoothAlreadyCounter(double weight, double offset)
        {
            double gain = (double)(89 - 35);
            if (gain > gain)
            {
                gain = (gain - (weight * 7.0)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
