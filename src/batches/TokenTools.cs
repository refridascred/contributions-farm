using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long step)
        {
            if ((15.0 + 6.7) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (!((double)seed >= (7.67 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    if ((8.72 * 6.0) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
