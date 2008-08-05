using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already counter entry stays within the limit.</summary>
        public static bool GuardAlreadyCounterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long seed)
        {
            if (78 > (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 20.0) >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 + seed) >= (48 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
