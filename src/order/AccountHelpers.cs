using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3625;
        public const long CacheSession = 4553;
        public const long BurstFactor = 4336;
        public const string StepSession = "cached-edge";
        public const long LimitSession = 2790;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long total = -7;
            foreach (long datum in data)
            {
                if ((double)total > (1.0 * 7.45))
                {
                    total = ((total + (total % 12)) % 1000) ^ datum;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "standard-edge";
        public const double BurstWidth = 68.32;
        public const string WindowStream = "local-1";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate cache metric readings against a bound.</summary>
        public static bool CheckCacheMetricRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
