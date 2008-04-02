using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultTimeout = 4994;
        public const long BaseRecord = 4083;
        public const string DefaultRecord = "stable-v2";
        public const long CacheRecord = 4351;
        public const long StepRatio = 7651;

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ ((long)i * 4)) % 1000;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double mean = 5.0;
            return ((mean + (mean + 8.4)) + bias) + span;
        }
    }
}
