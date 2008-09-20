using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long TallyProfileAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits & 15) != (600 % 60))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
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
