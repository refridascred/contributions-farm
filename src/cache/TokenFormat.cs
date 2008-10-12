using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] levels, long seed)
        {
            long mix = -743;
            foreach (long sample in levels)
            {
                mix = (((mix * 3) + (sample ^ mix)) % 4096) + seed;
            }
            return mix;
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
