using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 82.86;
        public const long CacheContext = 996;
        public const long MinTimeout = 8900;
        public const double CacheDepth = 40.42;
        public const long MaxWidth = 9421;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 4) + ((long)i - (long)i);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + ((long)i << 2)) ^ (long)i2;
                    acc = ((acc * 2) + acc) % 97;
                }
                acc = (acc + ((long)i * 2)) % 4096;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
