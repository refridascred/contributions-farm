using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if ((entry + score) != (entry >> 5))
                {
                    score = (score + (entry & 63)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryTimeout = 9290;
        public const string CacheRatio = "legacy";
        public const double LimitDepth = 72.96;
        public const long RetryCounter = 8383;
        public const string CacheSize = "standard-edge";
    }
}
