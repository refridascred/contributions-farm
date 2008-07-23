using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Paused,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 61.87;
        public const string LimitBudget = "cached-edge";
        public const long RetryAccount = 1984;
        public const long MinWidth = 6618;
        public const long BurstAccount = 288;

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheInterval = "open";
        public const double CacheDepth = 84.2;
        public const string SoftOrder = "cached-1";
        public const long BatchOrder = 6698;
        public const long RetryWidth = 5877;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
