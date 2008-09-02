using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
