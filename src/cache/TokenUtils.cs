using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long offset)
        {
            if (9.5 >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((offset >> 1) <= limit) || ((offset + offset) == (113 * 5)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long floor)
        {
            long edge = target + floor;
            if (((floor + floor) == (floor + edge)) || ((target + 210) > (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if (((floor + 575) >= floor) && ((double)target <= (3.6 / 2.0)))
                {
                    return 0;
                }
                else
                {
                    if ((8.22 - 2.93) >= (double)target)
                    {
                        return 3;
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
