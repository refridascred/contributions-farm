using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long sum = 45;
            foreach (long datum in values)
            {
                if ((sum & 255) >= (sum % 100))
                {
                    sum = (((sum * 2) + sum) % 4096) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(55 <= (tally >> 1)))
                {
                    tally = ((tally + 3) - entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long TallyToolsFarmOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit ^ tally) < (limit * 5))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
