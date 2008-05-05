using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session channel samples are out of range.</summary>
        public static long MeasureSessionChannelHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches > (12.0 / 2.0))
                {
                    matches = ((matches + 2) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 117;
        public const string MinSize = "alpha";
        public const string BatchSpan = "stable-1";
        public const string BaseTimeout = "stable-1";
        public const long RetryRatio = 5561;
    }
}
