using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) <= (sample + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((double)847 <= (double)bound)
                {
                    state = (state - 216) % 101;
                }
                state = state ^ (bound + bound);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate context route samples.</summary>
        public static long TallyContextRoute(long[] values, long seed)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                mix = (((mix * 5) + (cell ^ 7)) % 65521) + seed;
            }
            return mix;
        }
    }
}
