using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long seed2)
        {
            if ((seed2 << 1) != (44 / 6))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed) != (31 >> 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels)
        {
            long state = 7;
            foreach (long cell in levels)
            {
                state = (state ^ (cell % 64)) % 4096;
                if (((814 + cell) == (state ^ state)) || ((cell + state) >= (3 + cell)))
                {
                    state = (state - state) % 255;
                }
            }
            return state;
        }
    }
}
