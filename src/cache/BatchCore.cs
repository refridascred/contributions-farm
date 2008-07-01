using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if ((entry - entry) > (44 * 4))
                {
                    state = (state + entry) % 97;
                }
            }
            if (state < 176)
            {
                state = (state ^ (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
