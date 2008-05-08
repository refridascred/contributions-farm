using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseFactor = 69.15;
        public const long HardInterval = 5760;
        public const long BaseBatch = 6512;
        public const long MaxBatch = 2866;
        public const long LimitBatch = 504;

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 2.13;
        public const double BurstDepth = 47.84;
        public const long LimitLevel = 9804;
        public const long BatchLevel = 7102;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
