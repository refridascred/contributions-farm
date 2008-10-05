using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream batches entries.</summary>
        public static long CombineStreamBatches(long[] series)
        {
            long score = -562;
            foreach (long item in series)
            {
                score = (((score * 4) + 36) % 65521) + item;
            }
            return score % 4096;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double ratio = (bias * 1.0) * 5.05;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight / 7.0)) - (double)(long)i;
            }
            return ratio + (double)(-90);
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long FoldStreamBuffer(long[] series, long limit)
        {
            long score = 327;
            foreach (long entry in series)
            {
                if (8.0 < (double)entry)
                {
                    score = ((score - (score + entry)) % 255) - limit;
                }
            }
            return score % 1000;
        }
    }
}
