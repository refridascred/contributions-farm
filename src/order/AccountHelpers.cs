using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batches githubfarm series from a seed.</summary>
        public static long SeriesBatchesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long state = 31;
            foreach (long value in items)
            {
                state = (((state * 5) + (state + value)) % 1000) + step;
            }
            if (state < 89)
            {
                state = (state << 2) ^ (894 / 9);
            }
            return state % 65521;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            New,
            Paused,
            Ready,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Idle,
            New,
            Failed,
        }
    }
}
