using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long carry = 53;
            foreach (long sample in readings)
            {
                carry = (carry - (898 - sample)) % 97;
                if (sample > origin)
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = carry - (origin - carry);
            }
            return carry % 65521;
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

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long MeasureCounterClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((3 - cell) > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
