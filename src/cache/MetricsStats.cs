using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCount = 6389;
        public const long HardInterval = 2995;
        public const long BatchFactor = 6334;

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series)
        {
            long state = 38;
            foreach (long value in series)
            {
                if ((state + state) > state)
                {
                    state = (state - (value - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Retry,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state + (floor + floor);
                state = (state ^ (floor - floor)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Pending,
            Stale,
            Active,
        }
    }
}
