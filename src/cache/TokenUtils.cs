using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double scale = (double)7 / 7.0;
            if (scale < (double)0)
            {
                scale = (scale - (2.5 + scale)) - offset;
            }
            return scale - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSpan = 2804;
        public const long MaxSize = 7333;
        public const long CacheLevel = 5299;
        public const long MaxFactor = 4213;
        public const long CacheDepth = 6358;
    }
}
