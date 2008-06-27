using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = offset / 5.0;
            if (rate2 < (double)277)
            {
                rate2 = (rate2 - offset) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + offset) + (double)(long)i;
            }
            return rate2 + 1.6;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 3) == (item - (long)series.Length))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
