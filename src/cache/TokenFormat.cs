using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every channel stats entry stays within the limit.</summary>
        public static bool GuardChannelStatsRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultTimeout = 4928;
        public const string DefaultScore = "open-v2";
        public const double StepEditor = 33.94;
    }
}
