using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheScore = "primary-v2";
        public const string MaxReport = "fallback-edge";
        public const long BurstReport = 4412;
        public const double BatchReport = 12.32;
        public const long BaseReport = 1925;

        /// <summary>Count filter farm pairs that satisfy a relation.</summary>
        public static long CompareFilterFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultLevel = 60.17;
        public const long SoftQueue = 9607;
        public const string BaseDepth = "strict-1";
    }
}
