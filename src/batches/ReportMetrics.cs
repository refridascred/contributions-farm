using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 7436;
        public const long DefaultOrder = 7744;
        public const long MaxOrder = 9334;
        public const string RetryOrder = "strict-edge";
        public const long CacheWidth = 6546;

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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (long)i) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
