using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state - (floor & 1);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long anchor = 7;
            foreach (long reading in levels)
            {
                anchor = ((anchor - (floor & 127)) % 97) - reading;
            }
            return anchor;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
