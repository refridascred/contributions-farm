using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long origin)
        {
            long anchor = 15;
            foreach (long item in samples)
            {
                if ((origin / 3) > (item * 4))
                {
                    anchor = (anchor ^ (item % 12)) % 101;
                }
            }
            return anchor;
        }
    }
}
