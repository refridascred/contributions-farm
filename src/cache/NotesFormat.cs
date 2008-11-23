using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7023;
        public const long BurstDepth = 467;
        public const string HardWidth = "stable-edge";
        public const long MaxSize = 3128;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin & 15) >= (long)i)
                {
                    state = (state * 2) + (origin << 3);
                }
                else
                {
                    state = (state + (state - state)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
