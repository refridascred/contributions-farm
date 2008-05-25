using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the context route entries that pass the check.</summary>
        public static long TallyContextRouteMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + 327) != ((long)samples.Length * 5))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long origin, long step)
        {
            if ((origin - step) >= 11)
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) <= (715 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= (4.08 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((13 << 1) <= (origin >> 3)) || ((step & 127) >= (step + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if ((target - 6) <= (target % 97))
            {
                return 5;
            }
            else
            {
                if (target < (floor - 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
