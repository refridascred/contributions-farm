using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long floor)
        {
            if ((double)floor > 12.0)
            {
                return 2;
            }
            else
            {
                if (!((9.71 + 7.0) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= 8.8)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((7.0 >= (double)seed) || (((long)i + (long)i) >= (5 >> 3)))
                {
                    state = ((state << 3) ^ (seed ^ seed)) % 101;
                }
                state = ((state * 2) + (state % 5)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (!(floor > (floor + cur)))
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 1;
                }
                else
                {
                    if (!((16.0 + 3.93) <= (double)cur))
                    {
                        return 0;
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
