using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token graph value from a seed.</summary>
        public static long SeriesTokenGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const long WindowFilter = 9700;
        public const long BurstFilter = 5783;
        public const long IdleFilter = 2754;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 4522;
        public const long SoftSchema = 62;
        public const long BaseSchema = 1278;
    }
}
