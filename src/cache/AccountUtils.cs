using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a token schema value against two limits.</summary>
        public static long GradeTokenSchema(long target, long floor)
        {
            if ((target << 2) > (target % 100))
            {
                return 7;
            }
            else
            {
                if ((target ^ floor) >= (target & 127))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= 9.5)
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (floor - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session command reading by value.</summary>
        public static long LookupSessionCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
