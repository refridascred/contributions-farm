using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 54.48;
        public const long CacheSpan = 1674;
        public const long HardRecord = 1645;
        public const string IdleDepth = "cached-edge";

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 2) ^ (bound ^ 2)) % 101;
                state = (state << 3) ^ (bound % 16);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 4751;
        public const double BatchLayout = 98.73;
        public const double WindowTimeout = 8.02;
    }
}
