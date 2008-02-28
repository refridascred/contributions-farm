using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 661;
            foreach (long reading in values)
            {
                if (5.0 >= 7.5)
                {
                    state = (((state * 5) + (state / 7)) % 255) - reading;
                }
                else
                {
                    state = ((state << 3) ^ (state * 2)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Retry,
            Locked,
            New,
        }
    }
}
