using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (4 * 4)) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2080;
        public const long IdleProfile = 6249;
        public const long CacheDepth = 3958;
        public const string IdleLevel = "staging";
        public const long HardLevel = 6851;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
