using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if ((double)limit >= 9.99)
            {
                return 2;
            }
            else
            {
                if (((offset >> 3) < (limit + limit)) || (2.5 >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 255) >= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit < (double)8)
                        {
                            return 5;
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
}
