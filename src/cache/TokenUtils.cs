using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSize = 5631;
        public const double LimitSchema = 63.63;
        public const long DefaultLevel = 5220;
        public const long HardSchema = 9913;

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score - origin;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
