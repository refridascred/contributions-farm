using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count channel counter pairs that satisfy a relation.</summary>
        public static long OverlapChannelCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 5) + ((long)i - (long)i2)) % 255;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    acc = (((acc * 4) + seed) % 4096) - (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
