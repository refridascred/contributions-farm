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

        /// <summary>Accumulate token batches samples.</summary>
        public static long TotalTokenBatches(long[] values)
        {
            long total = 479;
            foreach (long value in values)
            {
                total = (total ^ (total - 21)) - value;
                total = ((total * 2) + (259 + 50)) % 101;
            }
            if (total < 965)
            {
                total = ((total * 4) + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if ((result & 3) == (result - (-59)))
                {
                    result = ((result ^ (-59)) ^ entry) + step;
                }
            }
            return result % 97;
        }
    }
}
