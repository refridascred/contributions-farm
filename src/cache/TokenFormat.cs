using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (73 % 7)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((limit * 4) < (seen + limit))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Done,
            Pending,
        }
    }
}
