using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSpan = 3987;
        public const string HardBudget = "primary-edge";
        public const long IdleWidth = 7843;
        public const string BurstScore = "fallback-1";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((limit * 4) < (seen + limit))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Done,
            Pending,
        }
    }
}
