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

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long origin)
        {
            if (bound < (bound << 3))
            {
                return 0;
            }
            else
            {
                if (!((origin * 2) > (origin / 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
