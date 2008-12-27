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

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheFactor = "stable-edge";
        public const string WindowOrder = "standard";
        public const long CacheOrder = 1503;
        public const long HardOrder = 8163;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 4522;
        public const long SoftSchema = 62;
        public const long BaseSchema = 1278;
    }
}
