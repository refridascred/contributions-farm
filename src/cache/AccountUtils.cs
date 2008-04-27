using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series, long bound)
        {
            long acc = -938;
            foreach (long value in series)
            {
                acc = ((acc + (76 % 64)) ^ value) - bound;
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-4) - tally) > (tally / 8))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)limit >= (double)73) && (limit > (limit * 4)))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
