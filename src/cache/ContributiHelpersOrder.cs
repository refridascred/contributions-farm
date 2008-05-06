using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long anchor = 797;
            foreach (long datum in items)
            {
                anchor = (anchor - floor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] series, long limit)
        {
            long state = 272;
            foreach (long sample in series)
            {
                state = (state + sample) - limit;
            }
            return state;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
