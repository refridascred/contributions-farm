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

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] data, long origin)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                if ((item <= (item - item)) || ((anchor + item) >= 0))
                {
                    anchor = ((anchor + anchor) % 255) + origin;
                }
                else
                {
                    anchor = (anchor + (169 >> 2)) % 1000;
                }
                if (((4 / 6) >= (item / 2)) || ((item * 5) <= item))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
