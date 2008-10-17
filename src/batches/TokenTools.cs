using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long offset)
        {
            long diff = seed ^ offset;
            if (5.0 <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((diff << 2) < diff) && ((5.36 - 1.71) != (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset - diff) > (seed << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed ^ 830) >= 6) && ((double)seed >= (8.12 + 1.45)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
