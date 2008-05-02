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

        /// <summary>Digest a series of format commits entries.</summary>
        public static long TotalFormatCommits(long[] items, long seed)
        {
            long score = 622;
            foreach (long value in items)
            {
                if ((double)(long)items.Length >= 2.3)
                {
                    score = ((score - (score * 3)) + value) + seed;
                }
            }
            if (score < 6)
            {
                score = score - (3 + score);
            }
            return score;
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
