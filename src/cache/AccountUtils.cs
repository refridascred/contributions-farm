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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long bound)
        {
            long prev = offset + bound;
            if ((8 >> 4) < bound)
            {
                return 5;
            }
            else
            {
                if ((bound ^ 229) >= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (offset > (prev ^ prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
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
