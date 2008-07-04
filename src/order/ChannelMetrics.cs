using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseScore = "fallback";
        public const string CacheQueue = "local-edge";
        public const long RetryQueue = 7749;

        /// <summary>Combine cache profile values into a single score.</summary>
        public static long ScoreCacheProfile(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = (total << 3) ^ (item - total);
                if (((double)total >= (9.0 * 19.0)) || (item > (188 - item)))
                {
                    total = (total - item) % 1000;
                }
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
