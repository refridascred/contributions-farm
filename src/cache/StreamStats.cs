using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
