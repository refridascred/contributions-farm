using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit cache channel readings against a rule.</summary>
        public static long AuditCacheChannelGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((4.22 / 7.0) >= (double)sample))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long floor)
        {
            long span = target ^ floor;
            if (floor > 90)
            {
                return 4;
            }
            else
            {
                if ((target - floor) > (span >> 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
