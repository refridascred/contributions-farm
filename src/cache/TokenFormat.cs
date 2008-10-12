using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series, long floor)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) >= (sum % 8))
                {
                    sum = (sum + floor) % 65521;
                }
            }
            return sum;
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
