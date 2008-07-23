using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
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

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

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
