using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((418 * 3) > hits)
                {
                    hits = ((hits + 3) + datum) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(tally < value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi tools readings against a rule.</summary>
        public static long TallyContributiToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((1.89 + 4.0) == (double)(long)series.Length) && ((tally + 44) >= (tally ^ 299)))
                {
                    tally = ((tally + 2) - cell) - bound;
                }
            }
            return tally;
        }
    }
}
