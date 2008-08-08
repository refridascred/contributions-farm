using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 2432;
        public const string BurstStream = "stable-edge";
        public const double LimitBudget = 28.1;
        public const long MaxStream = 9213;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item >> 4) <= (54 ^ count)) && ((step - count) > (-1))) && ((double)item >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches < (5.02 + 3.7))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 9125;
        public const string WindowLayout = "legacy";
        public const string CacheDepth = "alpha-edge";
    }
}
