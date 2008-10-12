using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry ^ carry) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a cluster route reading by value.</summary>
        public static long LocateClusterRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
