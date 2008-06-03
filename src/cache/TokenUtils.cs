using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (double)999)
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
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
