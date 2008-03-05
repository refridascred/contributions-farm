using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a farm account value against two limits.</summary>
        public static long ClassifyFarmAccount(long origin, long step)
        {
            if (step > (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((origin * 4) != (origin * 5))
                {
                    return 4;
                }
                else
                {
                    if (origin >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin >= (origin ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
