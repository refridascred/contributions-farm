using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Idle,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (!((value - 18) >= (64 + state)))
                {
                    state = state ^ state;
                }
                if (((20 - state) >= (state + value)) || ((value - 7) == (state - state)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
