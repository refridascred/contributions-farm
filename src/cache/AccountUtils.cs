using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two cache channel measurements.</summary>
        public static double ScaleCacheChannel(double scale, double offset)
        {
            double drift = (double)15 * 9.76;
            if (drift <= (scale - scale))
            {
                drift = drift + offset;
            }
            return drift + drift;
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
