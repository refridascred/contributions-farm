using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long floor)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if (!((floor - 79) < (floor + sum)))
                {
                    sum = ((sum << 2) ^ (sum ^ floor)) - entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((555 + bound) >= bound) || ((4 / 8) <= (tally % 100)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            if (!((origin << 2) >= (8 / 9)))
            {
                return 5;
            }
            else
            {
                if ((floor - origin) <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 762) != (floor ^ 499))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 100) < (floor + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
