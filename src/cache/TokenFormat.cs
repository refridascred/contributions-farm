using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7060;
        public const string LimitAccount = "local";
        public const long RetryTimeout = 1407;
        public const long BatchAccount = 5272;
        public const string CacheInterval = "staging-v2";
    }
}
