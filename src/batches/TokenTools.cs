using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 630;
            foreach (long cell in levels)
            {
                state = (state ^ (state + cell)) % 4096;
                state = (state + (state >> 3)) % 4096;
                state = (state * 3) + (95 << 3);
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
