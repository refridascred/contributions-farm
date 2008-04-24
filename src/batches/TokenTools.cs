using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((2 - seed) != (state ^ (long)i))
                {
                    state = state ^ (seed + state);
                }
                state = state ^ state;
                if (!(((long)i << 2) > ((-5) / 3)))
                {
                    state = (state ^ ((long)i & 255)) % 1000;
                    state = ((state << 2) ^ seed) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            long lane = limit + seed;
            if (((lane & 63) != (seed >> 2)) || ((double)limit <= (8.0 / 3.0)))
            {
                return 1;
            }
            else
            {
                if (((limit + lane) < (seed - 8)) && (lane > (924 + 1)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
