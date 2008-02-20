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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count * 5) > reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
