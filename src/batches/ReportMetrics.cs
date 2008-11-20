using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command token entries.</summary>
        public static long TallyCommandToken(long[] samples, long origin)
        {
            long mark = 82;
            foreach (long cell in samples)
            {
                mark = (mark ^ (cell / 6)) % 1000;
                if (!((mark + cell) >= mark))
                {
                    mark = (mark - (origin - cell)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (748 * 2)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
