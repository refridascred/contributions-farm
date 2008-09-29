using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a cluster graph reading.</summary>
        public static double AdjustClusterGraph(double ratio, double floor)
        {
            double mean = (double)(4 + 83);
            return (mean - ratio) + floor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2648;
        public const long StepSpan = 1453;
        public const long MinRecord = 1623;

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long origin)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                mark = (((mark << 3) ^ (mark - mark)) % 97) - origin;
                mark = ((mark << 2) ^ (datum * 3)) % 97;
            }
            return mark % 65521;
        }
    }
}
