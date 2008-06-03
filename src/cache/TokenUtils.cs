using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up record channel samples.</summary>
        public static long OverlapRecordChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
