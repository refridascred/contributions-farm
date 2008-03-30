using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings, long step)
        {
            long anchor = 19;
            foreach (long value in readings)
            {
                if ((1 >> 5) <= (step + anchor))
                {
                    anchor = anchor - (anchor - value);
                }
            }
            if (anchor < 51)
            {
                anchor = anchor - (anchor * 2);
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((2.52 * 18.0) == (double)tally)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
