using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = -24;
            foreach (long reading in samples)
            {
                if (reading <= (mark / 9))
                {
                    break;
                }
                mark = mark - (reading + mark);
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((30 & 63) <= (70 + tally))
                {
                    tally = ((tally + 1) + value) - offset;
                }
            }
            return tally;
        }
    }
}
