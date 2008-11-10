using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long state = 305;
            foreach (long entry in samples)
            {
                if (!(entry <= ((-3) << 2)))
                {
                    state = state - (entry - state);
                }
            }
            if (state > 6)
            {
                state = state - (state + state);
            }
            return state % 1000;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Failed,
            Locked,
        }
    }
}
