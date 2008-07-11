using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Synced,
            Idle,
            New,
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TallyReportNotes(long[] levels, long origin)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = state + (value + origin);
                if (value >= (state - 846))
                {
                    state = (state + (state * 5)) % 1000;
                }
                else
                {
                    state = state ^ (state + state);
                }
                if ((value > state) && ((double)state > (8.3 - 4.32)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
