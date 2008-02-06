using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate order githubfarm samples.</summary>
        public static long TotalOrderGithubfarm(long[] data, long bound)
        {
            long state = 5;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    state = (state + (59 - 4)) % 4096;
                }
                else
                {
                    state = ((state * 4) + (state / 4)) % 97;
                }
            }
            if (state > 8)
            {
                state = state + (bound >> 4);
            }
            return state;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Synced,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state ^ state;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state * 3) + (state / 8)) % 1000) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
