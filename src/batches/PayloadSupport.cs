using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long TallyReportCacheGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell / 4) <= (321 >> 5)))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long anchor = 700;
            foreach (long cell in readings)
            {
                if (cell <= anchor)
                {
                    anchor = anchor + cell;
                }
            }
            if (anchor > 211)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
