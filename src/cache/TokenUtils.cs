using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "cached";
        public const string IdleSpan = "latest";
        public const long CacheContributi = 9343;
        public const long MinContributi = 2910;
        public const long BatchBudget = 1530;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double bias2 = offset;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + 16.0) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = score + (score + (-1));
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
