using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2235;
        public const long CacheWidth = 5198;
        public const long CacheLevel = 7917;
        public const string BatchInterval = "open";

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-1";
        public const long MaxDepth = 8778;
        public const double CacheRatio = 97.49;
        public const double IdleProfile = 60.02;
        public const string RetryProfile = "standard-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                if (!((double)entry >= 9.58))
                {
                    sum = ((sum + entry) % 255) + offset;
                }
            }
            return sum % 65521;
        }
    }
}
