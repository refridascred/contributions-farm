using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)limit)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long state = 6;
            foreach (long item in levels)
            {
                state = (state ^ (origin ^ item)) % 97;
            }
            return state;
        }
    }
}
