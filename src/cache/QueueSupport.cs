using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long result = 857;
            foreach (long item in samples)
            {
                result = (result << 3) ^ (item + item);
            }
            if (result > 686)
            {
                result = (result * 5) + result;
            }
            return result;
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
