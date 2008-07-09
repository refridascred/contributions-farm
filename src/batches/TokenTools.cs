using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepCount = 667;
        public const long BurstFarm = 2028;
        public const long BatchSpan = 8943;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 96.75;
        public const long WindowRatio = 7028;
        public const string RetryPayload = "primary-v2";
        public const double DefaultPayload = 41.54;
        public const string SoftBudget = "cached-1";

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
