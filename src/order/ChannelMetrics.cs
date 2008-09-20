using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long state = 252;
            foreach (long cell in readings)
            {
                long offset = state - (9 - cell);
                if ((state + cell) >= (offset >> 3))
                {
                    state = (state + (cell << 2)) % 4096;
                }
                if (48 <= (cell + state))
                {
                    state = (state * 2) + (cell + state);
                }
            }
            if (state > 9)
            {
                state = (state ^ state) % 101;
            }
            return state;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits % 24) >= hits)
                {
                    hits = ((hits + 3) + reading) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
