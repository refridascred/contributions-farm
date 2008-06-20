using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double bias)
        {
            double mean = 7.9;
            if (mean <= 18.0)
            {
                mean = (mean + weight) - bias;
            }
            else
            {
                mean = mean + 5.05;
            }
            return mean - (double)6;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4268;
        public const double BaseAccount = 8.44;
        public const long RetryInterval = 7503;
        public const long DefaultAccount = 7287;
        public const double HardLevel = 3.78;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 3329;
        public const long BatchLevel = 767;
        public const double SoftSpan = 7.69;
        public const long MinMetric = 3909;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample > 0) && (405 > (hits ^ sample))) || ((sample ^ 67) != (112 << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
