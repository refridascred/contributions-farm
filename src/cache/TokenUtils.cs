using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 2328;
        public const string CacheSpan = "latest";
        public const long SoftOrder = 6661;
        public const long CacheOrder = 3631;
        public const long BurstOrder = 1064;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 25.53;
        public const long MinRatio = 3256;
        public const long SoftEditor = 6569;
    }
}
