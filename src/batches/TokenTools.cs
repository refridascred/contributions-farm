using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long origin)
        {
            if ((offset << 1) != (origin / 6))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((offset << 3) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) || ((offset - offset) != (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i > sum)
                {
                    break;
                }
                else
                {
                    sum = sum ^ sum;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum * 3) + (8 << 2)) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
