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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + mark) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark - (floor + mark)) % 97) - (long)i2;
                }
                mark = mark + (floor - floor);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
