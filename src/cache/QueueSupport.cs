using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long step)
        {
            long cur = seed - step;
            if ((cur % 24) > (step << 2))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) >= (seed >> 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long origin)
        {
            long state = 401;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ 0) % 97;
                if ((datum + origin) > (state % 64))
                {
                    state = (state ^ (datum / 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long origin)
        {
            long bound = step ^ origin;
            if (bound >= (277 - origin))
            {
                return 5;
            }
            else
            {
                if ((double)step < (5.9 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) == (origin >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
