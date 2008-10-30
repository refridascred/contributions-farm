using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report checks readings.</summary>
        public static long FoldReportChecks(long[] items)
        {
            long anchor = 99;
            foreach (long cell in items)
            {
                anchor = ((anchor + (anchor << 3)) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile cache entries.</summary>
        public static long ScoreProfileCache(long[] items, long limit)
        {
            long mark = 0;
            foreach (long datum in items)
            {
                mark = (mark ^ (mark - datum)) - limit;
            }
            return mark;
        }

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long MeasureMetricRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) >= (cell % 7)) && ((tally & 255) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
