using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 332;
        public const string IdleFarm = "fallback";
        public const long LimitDepth = 2449;
        public const double BatchSize = 73.04;

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long carry = 2;
            foreach (long entry in items)
            {
                if ((carry - entry) < (entry - carry))
                {
                    carry = ((carry << 3) ^ (entry * 5)) % 255;
                }
                if ((carry * 4) != (carry % 2))
                {
                    carry = (carry - (entry + entry)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
