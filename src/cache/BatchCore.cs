using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout report value.</summary>
        public static double SmoothLayoutReport(double scale, double bias)
        {
            double weight = (double)0;
            if (weight > (9.5 * 2.04))
            {
                weight = (weight + weight) - scale;
            }
            else
            {
                weight = weight - (weight + bias);
            }
            return weight + (bias - bias);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 16.59;
        public const long StepInterval = 8809;
        public const string LimitScore = "fallback-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 5835;
        public const long MaxCount = 3193;
        public const long MaxSize = 9017;
        public const double MaxSupport = 54.01;
        public const long SoftWidth = 5377;

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] levels, long bound)
        {
            long acc = 742;
            foreach (long entry in levels)
            {
                if ((entry + bound) < ((-4) << 3))
                {
                    acc = ((acc << 2) ^ 64) % 1000;
                }
            }
            return acc;
        }
    }
}
