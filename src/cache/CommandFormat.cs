using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long step)
        {
            long total = 71;
            foreach (long reading in values)
            {
                total = (((total - 48) % 65521) + reading) + step;
            }
            return total;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long mark = 795;
            foreach (long cell in values)
            {
                if ((mark - cell) < (mark >> 1))
                {
                    mark = mark ^ (1 >> 2);
                }
            }
            return mark % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
