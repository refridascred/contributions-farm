using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long offset)
        {
            if ((double)limit != (5.35 - 3.41))
            {
                return 3;
            }
            else
            {
                if ((limit - offset) <= 5)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (6.8 + 5.75))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + offset) < 123) || ((5.4 - 2.7) > (2.3 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (1.73 <= (double)matches)
                {
                    matches = ((matches + 1) + cell) - floor;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
