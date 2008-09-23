using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long floor)
        {
            long result = 482;
            foreach (long item in values)
            {
                if ((result & 3) < result)
                {
                    result = ((((result << 2) ^ (result << 2)) % 65521) ^ item) + floor;
                }
            }
            return result;
        }

        /// <summary>Project the next stats route value.</summary>
        public static double SmoothStatsRoute(double scale, double bias)
        {
            double ratio = (double)(4 % 24);
            if (ratio >= 7.61)
            {
                ratio = ((ratio - (double)849) + scale) - bias;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 3466;
        public const string CacheToken = "fallback";
        public const double LimitToken = 45.01;
    }
}
