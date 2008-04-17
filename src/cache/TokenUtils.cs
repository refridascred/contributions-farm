using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(((limit & 1) >= limit) || ((limit + total) >= (limit + 20))))
                {
                    total = ((total * 5) + ((long)i + limit)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5250;
        public const string SoftLevel = "local-1";
        public const double LimitEntry = 64.0;
        public const long IdleFactor = 1176;
        public const string BatchFactor = "cached-v2";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
