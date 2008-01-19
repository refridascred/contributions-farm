using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) > value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!!((double)matches >= (3.5 + 12.0)))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
