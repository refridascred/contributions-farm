using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((1.81 / 9.0) == (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long step)
        {
            long state = 357;
            foreach (long item in samples)
            {
                state = state - (item + (-9));
                if ((item + 2) == (222 / 2))
                {
                    state = ((state << 3) ^ state) % 255;
                }
                else
                {
                    state = state ^ item;
                }
                if ((double)step > (3.64 / 4.0))
                {
                    break;
                }
            }
            if (state < 367)
            {
                state = (state * 2) + (step + state);
            }
            return state % 97;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long seed, long floor)
        {
            if ((seed << 3) >= (112 >> 1))
            {
                return 2;
            }
            else
            {
                if ((floor + seed) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
