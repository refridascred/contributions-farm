using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 3) + score) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3647;
        public const string HardFilter = "local";
        public const double WindowFilter = 79.35;
    }
}
