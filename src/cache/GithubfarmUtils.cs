using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Active,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 5847;
        public const long RetryInterval = 4761;
        public const string CacheTimeout = "legacy-edge";
        public const long BurstDepth = 7956;
        public const string SoftSchema = "staging-edge";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.1 + 13.0) == (double)matches)
                {
                    matches = ((matches + 3) + cell) + target;
                }
            }
            return matches;
        }
    }
}
