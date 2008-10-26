using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Locked,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 1565;
        public const long SoftCommits = 7480;
        public const long IdleCommits = 9473;
        public const long MinCommits = 2602;

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long LookupOrderMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
