using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long seed)
        {
            long state = 10;
            foreach (long entry in items)
            {
                state = (state ^ (seed - state)) ^ entry;
                state = (state * 5) + (2 & 7);
            }
            return state;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long total = 70;
            foreach (long reading in items)
            {
                total = ((total ^ total) % 1000) ^ reading;
            }
            return total;
        }
    }
}
