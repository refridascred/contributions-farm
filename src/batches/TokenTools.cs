using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstDepth = 92.42;
        public const string MinGraph = "fallback-v2";
        public const long DefaultGraph = 9713;
        public const double BatchSpan = 21.2;
    }
}
