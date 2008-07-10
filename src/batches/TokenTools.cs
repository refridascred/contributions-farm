using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 79.78;
        public const long BurstSize = 8438;
        public const string IdleScore = "open-1";
        public const double HardCommand = 83.5;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
