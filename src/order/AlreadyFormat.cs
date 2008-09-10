using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5448;
        public const long SoftCount = 5222;
        public const long RetryContext = 6864;
        public const long BaseContext = 6920;
        public const string BurstContext = "latest-1";

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long bound)
        {
            if ((bound - limit) <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) <= (limit * 2))
                {
                    return 2;
                }
                else
                {
                    if (!((10 * 3) < (bound * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryDepth = 3395;
        public const long CacheFactor = 4434;
        public const string BatchSupport = "cached-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8361;
        public const double IdleProfile = 39.27;
        public const long SoftProfile = 463;
        public const string CacheProfile = "fallback-edge";
        public const long MaxDepth = 6323;
    }
}
