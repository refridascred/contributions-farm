using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            New,
            Failed,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long offset)
        {
            long state = 6;
            foreach (long item in readings)
            {
                state = state ^ (offset + item);
                if ((9.91 + 5.69) < (double)offset)
                {
                    state = (state - item) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
