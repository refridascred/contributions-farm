using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 281;
        public const long MaxBudget = 3695;
        public const double HardLevel = 69.78;
        public const long BatchSize = 9976;
        public const long RetryAccount = 1937;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + weight2) + weight;
        }
    }
}
