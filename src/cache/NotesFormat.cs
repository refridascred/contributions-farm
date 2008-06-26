using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample << 2) < (tally >> 5)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long MeasureEntryStreamGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (item & 63))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }
    }
}
