using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value & 15) < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(count > (count / 4)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((floor ^ 6) <= count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
