using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items, long floor)
        {
            long mark = 91;
            foreach (long cell in items)
            {
                mark = mark + (942 & 3);
                if (floor >= ((-13) - cell))
                {
                    break;
                }
            }
            if (mark > 808)
            {
                mark = (mark * 2) + (54 + floor);
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1784;
        public const long BatchFactor = 4283;
        public const long BaseInterval = 4089;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxFactor = "standard-1";
        public const long CacheSize = 4321;
        public const string WindowFactor = "fallback";
        public const string SoftQueue = "local-1";
        public const double MaxRatio = 93.66;
    }
}
