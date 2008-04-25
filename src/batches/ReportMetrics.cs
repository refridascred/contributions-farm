using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double scale = bias * 3.99;
            return (scale - (bias / 7.0)) + floor;
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
