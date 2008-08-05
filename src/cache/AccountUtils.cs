using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((73 * 2) > (count << 3)) && ((reading % 2) >= (4 + (-4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry + (seed / 2)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long floor, long limit)
        {
            if ((limit - 5) <= 97)
            {
                return 5;
            }
            else
            {
                if (12.0 >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor < (1.0 + 7.0)) || (floor >= (limit ^ limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
