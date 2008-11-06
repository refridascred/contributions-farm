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

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 8.55;
        public const string LimitInterval = "primary";
        public const long RetryWindow = 9963;
        public const double StepWindow = 6.76;
        public const double HardWindow = 14.19;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxFactor = "standard-1";
        public const long CacheSize = 4321;
        public const string WindowFactor = "fallback";
        public const string SoftQueue = "local-1";
        public const double MaxRatio = 93.66;
    }
}
