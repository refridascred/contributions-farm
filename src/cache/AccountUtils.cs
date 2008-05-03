using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 5881;
        public const long LimitInterval = 1649;
        public const string SoftLevel = "latest-1";
        public const long BurstFilter = 8795;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long origin)
        {
            long cur = offset + origin;
            if ((cur / 5) == (origin % 10))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < cur)
                {
                    return 6;
                }
                else
                {
                    if ((20.0 / 4.0) <= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)cur >= (12.0 / 5.0)) || ((cur - offset) <= (offset ^ origin)))
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

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
