using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
