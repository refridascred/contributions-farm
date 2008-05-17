using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long state = 879;
            foreach (long item in items)
            {
                if ((double)state <= (8.3 - 9.6))
                {
                    state = state ^ (state - item);
                }
            }
            return state;
        }

        /// <summary>Count the payload layout entries that pass the check.</summary>
        public static long CountPayloadLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally % 5) <= tally))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
