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

        /// <summary>Compare every pair of record farm readings.</summary>
        public static long MatchRecordFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
