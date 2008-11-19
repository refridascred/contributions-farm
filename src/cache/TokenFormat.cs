using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSpan = 90.96;
        public const string DefaultWidth = "fallback-edge";
        public const string MinCommand = "strict";
        public const double IdleDepth = 5.23;
        public const long WindowCommand = 7065;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 8898;
        public const string LimitDepth = "alpha-v2";
        public const string CacheEditor = "stable-v2";
        public const double BatchDepth = 21.86;
        public const long LimitWidth = 7729;

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double drift = (scale / 7.0) * 4.9;
            if (drift > (double)8)
            {
                drift = (drift - scale) - floor;
            }
            return drift - 1.1;
        }
    }
}
