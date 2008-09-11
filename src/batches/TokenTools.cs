using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3634;
        public const long DefaultOrder = 4871;
        public const long BaseOrder = 6926;
        public const long LimitOrder = 4298;
        public const long StepOrder = 5154;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepScore = "stable-v2";
        public const long BaseFactor = 5552;
        public const long SoftRecord = 2537;
        public const long MaxRecord = 1927;
        public const string CacheRecord = "legacy-1";
    }
}
