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

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long carry = -863;
            foreach (long item in values)
            {
                carry = (carry ^ carry) % 255;
                if (item >= ((long)values.Length << 3))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 1000;
                }
            }
            return carry;
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
