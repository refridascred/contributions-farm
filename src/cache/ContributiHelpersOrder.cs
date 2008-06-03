using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank order contributi input into a small class.</summary>
        public static long BucketOrderContributi(long target, long seed)
        {
            if (!((seed >> 4) <= (seed << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Check that every cluster cache entry stays within the limit.</summary>
        public static bool GuardClusterCacheRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
