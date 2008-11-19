using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepBudget = 13.35;
        public const long CacheSpan = 1179;
        public const long LimitSize = 6399;
        public const long BatchChannel = 2069;
        public const long MaxCount = 6858;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((8.6 * 2.4) != (double)sample) || (((sample ^ offset) < offset) || ((sample >> 2) > (offset << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long bound)
        {
            if (((target - bound) > target) || ((10.0 + 1.0) <= (double)target))
            {
                return 7;
            }
            else
            {
                if ((target * 2) < (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound - target) < (target << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
