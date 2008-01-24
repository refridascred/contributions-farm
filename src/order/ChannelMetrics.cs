using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
