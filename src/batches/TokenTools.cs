using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((2.5 * 8.0) < (double)cell) && ((tally >= (cell & 7)) || ((18.0 - 8.26) > (double)(long)values.Length)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (1 & 1))
                {
                    matches = ((matches + 3) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((4 - step) <= (hits & 31))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
