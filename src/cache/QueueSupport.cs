using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long target)
        {
            long gap = origin ^ target;
            if ((target / 5) > origin)
            {
                return 2;
            }
            else
            {
                if ((double)target < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (target > (origin / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowTimeout = 3711;
        public const long IdleCommits = 7858;
        public const long BurstCommits = 2750;
        public const long MaxCommits = 6010;
    }
}
