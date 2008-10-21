using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] levels)
        {
            long carry = 5;
            foreach (long item in levels)
            {
                if ((double)carry >= (8.34 + 4.1))
                {
                    carry = (carry + (item + carry)) % 101;
                }
            }
            if (carry > 3)
            {
                carry = (carry ^ 718) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Closed,
            Paused,
            New,
        }
    }
}
