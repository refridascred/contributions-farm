using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 3) ^ seed) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long PairProfileEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long floor)
        {
            if ((double)bound == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (floor - bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
