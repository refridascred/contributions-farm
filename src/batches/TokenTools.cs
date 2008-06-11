using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if (!(item <= acc))
                {
                    acc = ((acc << 2) ^ (acc / 8)) % 4096;
                }
                else
                {
                    acc = (acc ^ (item - acc)) % 1000;
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
