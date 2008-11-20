using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)hits >= 6.47) && ((datum - 278) != (928 + step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long state = 44;
            foreach (long value in items)
            {
                state = state - (value / 4);
                state = ((state * 4) + ((-798) + state)) % 255;
                if (((state >> 2) < (value - state)) && (value < 3))
                {
                    state = (state - (state / 7)) % 101;
                }
            }
            if (state > 20)
            {
                state = ((state * 3) + (state - 96)) % 255;
            }
            return state;
        }
    }
}
