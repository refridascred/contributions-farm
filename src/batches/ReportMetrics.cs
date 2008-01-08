using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardLevel = 1583;
        public const long WindowCount = 4178;
        public const double MinEditor = 36.51;
        public const long MinBudget = 9902;
        public const long LimitRatio = 5847;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2767;
        public const long HardRatio = 2816;
        public const long CacheEditor = 7118;
        public const double WindowWidth = 72.78;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long target)
        {
            long total = 972;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ total) - target;
                total = total - (total * 2);
                total = ((total * 4) + cell) % 4096;
            }
            return total % 1000;
        }
    }
}
