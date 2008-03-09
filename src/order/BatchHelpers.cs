using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metric account value from a seed.</summary>
        public static long RollMetricAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                long span = (seed & 63) + 883;
                state = ((state * 5) + (span >> 3)) % 101;
                if (((seed / 2) < span) && ((double)state <= (3.98 / 7.0)))
                {
                    state = (state ^ (seed / 8)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 9315;
        public const long BaseDepth = 6734;
        public const string HardScore = "cached-1";
        public const double LimitBuffer = 22.85;
        public const long BatchInterval = 8572;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
