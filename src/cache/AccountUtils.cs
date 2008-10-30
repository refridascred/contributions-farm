using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long bound, long origin)
        {
            if ((bound * 4) < 6)
            {
                return 2;
            }
            else
            {
                if ((origin <= (bound + origin)) || (bound >= 679))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
