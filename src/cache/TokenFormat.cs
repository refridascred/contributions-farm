using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long SeekAlreadyMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "primary-v2";
        public const long WindowContributi = 2361;
        public const double MaxTimeout = 88.32;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 3) ^ state;
                state = (state * 3) + (state >> 4);
                state = state ^ (origin + state);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
