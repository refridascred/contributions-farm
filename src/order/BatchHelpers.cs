using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Dropped,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long WeighCommitsQueue(long[] data)
        {
            long state = 68;
            foreach (long sample in data)
            {
                if (533 < (sample % 100))
                {
                    state = state ^ (sample + state);
                }
            }
            if (state < (-5))
            {
                state = (state * 2) + state;
            }
            return state % 1000;
        }
    }
}
