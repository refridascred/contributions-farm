using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 5345;
        public const long BatchDepth = 7120;
        public const long MinReport = 4758;
        public const double MaxReport = 34.04;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinSize = "stable-edge";
        public const long RetryCommand = 685;
        public const long MaxCommand = 6041;
        public const long BaseBudget = 8846;
        public const long BatchCommand = 8267;
    }
}
