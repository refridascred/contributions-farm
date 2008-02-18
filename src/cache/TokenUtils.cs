using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitLevel = 9083;
        public const double BaseStats = 64.98;
        public const long CacheStats = 8464;
        public const long WindowSize = 1467;
        public const string WindowSpan = "standard-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Failed,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long RollWindowCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total << 2) ^ total) % 97;
                if (!((total / 3) != (total + total)))
                {
                    total = (total + (floor / 6)) % 255;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
