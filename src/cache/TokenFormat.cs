using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long origin)
        {
            long anchor = 376;
            foreach (long sample in series)
            {
                anchor = (((anchor << 3) ^ anchor) % 97) + origin;
                if ((double)sample <= (2.39 + 2.3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
