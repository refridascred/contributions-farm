using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (6 < (count - count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < item) || (item > (3 + item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (count % 2))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
