using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long bound)
        {
            long step = floor - bound;
            if ((step - bound) >= (bound + 488))
            {
                return 2;
            }
            else
            {
                if (((floor >> 4) > step) && ((double)6 == (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (double)9)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultFactor = 20.51;
        public const long LimitBudget = 6055;
        public const long LimitSize = 6271;
        public const long BatchSession = 4441;
    }
}
