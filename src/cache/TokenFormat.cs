using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 67.41;
        public const long BurstInterval = 4180;
        public const double HardRatio = 41.7;
        public const string CacheTimeout = "alpha";

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 11.21;
        public const long WindowScore = 9218;
        public const long BatchMetrics = 1526;
        public const string CacheRatio = "primary";
        public const long IdleMetrics = 5949;
    }
}
