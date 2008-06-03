using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metrics command entries.</summary>
        public static long TallyMetricsCommand(long[] levels, long seed)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc << 2) ^ (item >> 5)) % 4096) - (long)i;
                }
                if (!((3.17 * 0.8) > (double)acc))
                {
                    acc = (acc << 2) ^ seed;
                }
                if ((1.81 / 3.0) >= (double)acc)
                {
                    acc = ((acc << 3) ^ 7) % 101;
                }
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6.83 < (double)entry)
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two token entry measurements.</summary>
        public static double ProjectTokenEntry(double gain, double offset)
        {
            double rate = (double)(599 ^ 6);
            if (rate >= rate)
            {
                rate = (rate - (rate + offset)) + gain;
            }
            else
            {
                rate = rate - (9.3 * 4.25);
            }
            return rate + offset;
        }
    }
}
