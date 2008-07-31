using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long target)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (target >> 4)) % 65521;
                if (target > (value & 127))
                {
                    break;
                }
            }
            return result % 1000;
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
