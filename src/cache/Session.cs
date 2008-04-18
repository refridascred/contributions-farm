using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Idle,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Stale,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) == (count - step))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftWidth = "cached-v2";
        public const long DefaultAlready = 2068;
        public const string CacheScore = "legacy-v2";
        public const long HardBudget = 3562;
        public const double CacheInterval = 27.23;
    }
}
