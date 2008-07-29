using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally < (value + value)) && ((tally + value) < (value / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
