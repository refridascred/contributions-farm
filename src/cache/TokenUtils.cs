using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 143;
            foreach (long entry in levels)
            {
                mark = (mark << 2) ^ (entry / 5);
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5043;
        public const long MaxDepth = 1903;
        public const double LimitTimeout = 61.99;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2511;
        public const string SoftContext = "standard-v2";
        public const string BurstDepth = "fallback";
    }
}
