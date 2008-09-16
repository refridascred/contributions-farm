using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long CountProfileToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell <= (52 - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3625;
        public const long IdleWindow = 8498;
        public const double HardFactor = 29.82;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((0 + item) < (item % 97))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
