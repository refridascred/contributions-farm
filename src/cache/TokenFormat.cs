using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics session entry stays within the limit.</summary>
        public static bool CheckMetricsSessionBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool GuardProfileGraphLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 84.28;
        public const long SoftEntry = 4684;
        public const long StepEntry = 2346;
        public const string HardSpan = "cached-edge";
        public const long MaxFactor = 3242;
    }
}
