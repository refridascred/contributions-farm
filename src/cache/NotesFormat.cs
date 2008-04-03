using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally < (tally % 12))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit / 3) < ((long)items.Length + hits))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = sum ^ entry;
            }
            return sum;
        }
    }
}
