using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((seen & 255) > (sample + sample)) && ((-6) <= (seen << 1))) || ((695 - 2) <= (seen % 64)))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
