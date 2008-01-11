using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((limit >= (seed + limit)) || ((seed & 31) <= (edge + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed - limit) > (edge % 5))
                {
                    return 4;
                }
                else
                {
                    if ((7 ^ edge) != (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((bound & 63) <= (state << 3)))
                {
                    state = (state + (9 * 2)) % 1000;
                }
                state = state - (state - bound);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading <= hits)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
