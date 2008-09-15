using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4339;
        public const long RetryChecks = 157;
        public const long HardBudget = 3125;
        public const double BaseDepth = 50.41;
        public const string CacheDepth = "stable-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7509;
        public const string DefaultRatio = "strict-edge";
        public const long LimitFactor = 1086;
        public const string IdleChecks = "latest";

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double gain2 = floor - (gain - floor);
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)17) + (double)(long)i;
            }
            return gain2 - (6.1 / 4.0);
        }

        /// <summary>Audit batches already readings against a rule.</summary>
        public static long TallyBatchesAlreadyHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((8.27 * 6.66) != (double)datum)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
