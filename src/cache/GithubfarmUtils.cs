using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cluster notes readings against a rule.</summary>
        public static long AuditClusterNotesOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample >> 2) < (sample / 3))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "staging-1";
        public const long BurstCount = 9222;
        public const long IdleRoute = 5862;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Retry,
            New,
            Stale,
        }
    }
}
