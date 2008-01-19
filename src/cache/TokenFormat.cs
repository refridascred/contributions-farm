using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first tools order entry that matches the target.</summary>
        public static long SeekToolsOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
