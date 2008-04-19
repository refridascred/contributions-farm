using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 9057;
        public const long WindowWidth = 6852;
        public const long BurstGithubfarm = 3237;
        public const long CacheBudget = 5656;
        public const long RetryBudget = 2890;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (12.0 > (19.0 / 3.0))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long offset, long seed)
        {
            if (offset < seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 1) >= (-21))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
