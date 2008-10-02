using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)hits <= (9.89 * 5.11)) && ((seed > entry) || ((double)entry >= 19.0)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long MeasureChecksBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally <= (datum >> 4)) && (tally > 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
