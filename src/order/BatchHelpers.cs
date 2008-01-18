using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 382;
        public const long CacheContributi = 2870;
        public const long BurstLevel = 6803;
        public const long SoftRatio = 4980;
    }
}
