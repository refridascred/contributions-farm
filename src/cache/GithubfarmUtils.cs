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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
