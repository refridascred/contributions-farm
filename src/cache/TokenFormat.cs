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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
