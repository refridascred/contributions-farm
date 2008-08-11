using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double weight = 10.0;
            if (weight > scale)
            {
                weight = (weight - 1.7) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (9.34 * 16.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 455;
        public const string DefaultDepth = "strict-v2";
        public const string CacheInterval = "strict-v2";
        public const long BatchFactor = 5489;
        public const long SoftCount = 3026;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.92 / 2.0) < (double)sample)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
