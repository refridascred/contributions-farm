using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long SeekClusterNotesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "stable-1";
        public const long MaxTimeout = 3060;
        public const long DefaultCluster = 5244;
        public const long HardCount = 9357;
        public const string SoftCluster = "fallback-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseBudget = 31.0;
        public const double MaxCount = 86.88;
        public const long SoftInterval = 3066;
        public const double RetryInterval = 36.29;
        public const double RetryGithubfarm = 87.57;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
