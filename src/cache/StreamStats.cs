using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] levels)
        {
            long state = 770;
            foreach (long value in levels)
            {
                if (((state << 3) != (value - 3)) || ((state << 3) < (state ^ state)))
                {
                    state = state - (value << 3);
                }
            }
            if (state > 41)
            {
                state = (state + (state / 9)) % 97;
            }
            return state;
        }

        /// <summary>Adjust a batches command reading.</summary>
        public static double ProjectBatchesCommand(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (bias * 2.2)) + weight;
            }
            return bias2 + (double)61;
        }
    }
}
