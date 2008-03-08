using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats order input into a small class.</summary>
        public static long GradeStatsOrder(long limit, long target)
        {
            if (((limit + target) != (target & 1)) || ((2.51 + 6.63) != (double)limit))
            {
                return 1;
            }
            else
            {
                if (!((target % 64) > limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 100) <= (limit + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Failed,
        }
    }
}
