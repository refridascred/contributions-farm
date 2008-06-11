using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items, long floor)
        {
            long acc = 2;
            foreach (long item in items)
            {
                if (acc > (item % 64))
                {
                    acc = (acc << 2) ^ (floor - item);
                }
                else
                {
                    acc = (acc << 3) ^ (floor & 63);
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            if ((double)floor <= (9.7 / 3.0))
            {
                return 6;
            }
            else
            {
                if (floor > (967 - 540))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 5) > floor)
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
}
