using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 1529;
        public const long BurstGithubfarm = 329;
        public const string StepGithubfarm = "legacy";
        public const long IdleTimeout = 965;

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long CountAccountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((-1) + cell) == (1 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
