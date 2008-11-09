using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a support farm counter forward.</summary>
        public static long SeriesSupportFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((carry - origin) > (carry << 3)) || ((long)i <= (8 * 3)))
                {
                    carry = ((carry * 5) + (479 / 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9217;
        public const string MinFactor = "strict-v2";
        public const long SoftWidth = 5948;
        public const long BaseBudget = 6135;
        public const string CacheStream = "cached-1";
    }
}
