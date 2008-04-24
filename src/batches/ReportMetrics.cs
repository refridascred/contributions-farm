using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= scale2)
            {
                scale2 = scale2 - (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - floor) + (double)(long)i;
            }
            return scale2 - (scale2 - floor);
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mark = 35;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ (mark >> 2)) % 1000) - datum;
            }
            if (mark > 9)
            {
                mark = (mark << 3) ^ seed;
            }
            return mark;
        }
    }
}
