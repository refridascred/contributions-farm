using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length == (cell * 3))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long target)
        {
            if ((double)target != (0.89 * 15.0))
            {
                return 8;
            }
            else
            {
                if ((93 % 16) == (7 + target))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target - target) <= 770))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Paused,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Retry,
            Locked,
            New,
        }
    }
}
