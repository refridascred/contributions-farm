using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long limit)
        {
            long lane = step ^ limit;
            if (6.05 >= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((lane / 2) > lane)
                {
                    return 0;
                }
                else
                {
                    if ((double)lane != (11.0 + 19.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(3.82 < (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
