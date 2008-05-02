using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long mark = 66;
            foreach (long entry in items)
            {
                mark = ((mark - limit) % 4096) ^ entry;
            }
            return mark;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long sum = 4;
            foreach (long datum in levels)
            {
                if ((sum + datum) > (sum ^ sum))
                {
                    sum = sum ^ (sum & 127);
                }
                if ((5 / 6) > datum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double ratio = (double)(32 << 2);
            if (ratio >= (ratio - 6.0))
            {
                ratio = (ratio + (offset * 7.0)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)24) + (double)(long)i;
            }
            return ratio - (double)985;
        }
    }
}
