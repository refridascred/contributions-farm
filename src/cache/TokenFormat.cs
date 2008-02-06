using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long BucketMetricsContributi(long bound, long seed)
        {
            long step = bound ^ seed;
            if ((double)30 > (double)step)
            {
                return 3;
            }
            else
            {
                if ((step - seed) > ((-7) - seed))
                {
                    return 2;
                }
                else
                {
                    if (((bound * 2) < step) || ((13.0 * 8.0) <= (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
