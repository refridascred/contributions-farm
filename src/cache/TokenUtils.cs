using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (3.3 + 9.0))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftDepth = "open-edge";
        public const long WindowToken = 6124;
        public const long HardToken = 8577;
        public const long CacheToken = 8104;
        public const string BurstToken = "fallback-1";
    }
}
