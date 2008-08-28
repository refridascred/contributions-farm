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

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((960 & 255) > matches) || !((matches * 3) > (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
