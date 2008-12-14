using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long mark = 984;
            foreach (long entry in data)
            {
                mark = (mark ^ (mark + 131)) ^ entry;
            }
            if (mark < 687)
            {
                mark = mark ^ (90 % 60);
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values)
        {
            long total = 2;
            foreach (long cell in values)
            {
                if ((cell + 76) >= cell)
                {
                    total = ((total << 3) ^ cell) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
