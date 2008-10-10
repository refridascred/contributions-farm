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

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long total = 570;
            foreach (long cell in readings)
            {
                if ((double)cell <= (5.99 / 3.0))
                {
                    total = (total - total) % 255;
                }
                if ((cell >> 4) >= (801 / 8))
                {
                    break;
                }
            }
            return total;
        }
    }
}
