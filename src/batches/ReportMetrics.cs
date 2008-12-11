using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long bound)
        {
            if ((562 & 63) < (offset << 2))
            {
                return 2;
            }
            else
            {
                if (64 >= bound)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long CombineAccountToken(long[] data)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (datum - 912);
            }
            return mark;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (scale - scale) + (scale + scale);
            if (weight > bias)
            {
                weight = weight - (bias * 6.85);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + (double)687;
        }
    }
}
