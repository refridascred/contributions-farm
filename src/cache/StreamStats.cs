using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate channel command samples.</summary>
        public static long TotalChannelCommand(long[] items, long bound)
        {
            long acc = -7;
            foreach (long cell in items)
            {
                if ((double)cell == (14.0 / 9.0))
                {
                    acc = (acc + (bound * 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Done,
            New,
            Failed,
            Active,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Paused,
            Closed,
            Retry,
            Idle,
        }
    }
}
