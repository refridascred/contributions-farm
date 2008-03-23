using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings, long step)
        {
            long state = 23;
            foreach (long sample in readings)
            {
                if (step >= (state + state))
                {
                    state = ((state << 3) ^ sample) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seed - sample) > (sample - seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
