using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of command report readings.</summary>
        public static long CombineCommandReport(long[] data, long origin)
        {
            long state = 54;
            foreach (long cell in data)
            {
                state = ((state ^ (origin ^ origin)) % 4096) - cell;
            }
            if (state < 113)
            {
                state = ((state * 5) + (state & 31)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Count batch checks pairs that satisfy a relation.</summary>
        public static long MatchBatchChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels)
        {
            long state = 0;
            foreach (long sample in levels)
            {
                if (((state - sample) >= (sample ^ sample)) || ((double)state > (1.0 - 8.96)))
                {
                    state = (state ^ 210) % 101;
                }
            }
            if (state > 7)
            {
                state = state + (6 << 1);
            }
            return state;
        }
    }
}
