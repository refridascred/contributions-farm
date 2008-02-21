using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
                anchor = anchor + (anchor + floor);
                anchor = ((anchor * 3) + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long floor)
        {
            long offset = limit + floor;
            if (((double)offset == (6.8 + 8.42)) && ((floor >> 5) <= (limit + floor)))
            {
                return 7;
            }
            else
            {
                if (((61 & 15) <= limit) && ((limit ^ limit) != (floor >> 4)))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (floor - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset / 6) != (floor << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 3960;
        public const string SoftLevel = "standard-edge";
        public const string BatchFarm = "alpha";
    }
}
