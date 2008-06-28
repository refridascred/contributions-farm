using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next buffer channel value from a seed.</summary>
        public static long SeriesBufferChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= datum)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session stream samples.</summary>
        public static long ScoreSessionStream(long[] levels, long limit)
        {
            long anchor = 348;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor & 127)) % 101) ^ value) - limit;
            }
            return anchor;
        }
    }
}
