using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Audit layout record readings against a rule.</summary>
        public static long CountLayoutRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (4.4 - 4.9))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item < (2.1 / 7.0))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
