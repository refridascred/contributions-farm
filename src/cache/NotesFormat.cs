using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long MeasureStatsAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value & 63) <= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long FoldNotesWindow(long[] data, long offset)
        {
            long mark = 985;
            foreach (long value in data)
            {
                mark = ((mark ^ offset) % 97) + value;
            }
            if (mark < 91)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
