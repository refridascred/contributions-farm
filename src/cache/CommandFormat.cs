using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((6.42 >= (double)tally) || ((tally + value) >= (tally * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (item + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
