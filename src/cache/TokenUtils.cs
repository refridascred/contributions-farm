using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 7061;
        public const long BatchFormat = 6248;
        public const string MinFormat = "cached-v2";
        public const long IdleRatio = 2592;
        public const long DefaultFormat = 1910;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Roll a format batches counter forward.</summary>
        public static long RollFormatBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark << 3) ^ (seed % 3)) % 255;
                mark = ((mark * 3) + (mark << 3)) % 101;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
