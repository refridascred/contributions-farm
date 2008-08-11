using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long carry = 247;
            foreach (long cell in readings)
            {
                if ((6.96 + 13.0) < (double)carry)
                {
                    carry = (((carry * 4) + carry) % 65521) - cell;
                }
            }
            if (carry > 3)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1652;
        public const long LimitEditor = 4620;
        public const long CacheEditor = 5066;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
