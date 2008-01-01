using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) <= (4 ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long step)
        {
            long total = 988;
            foreach (long sample in items)
            {
                total = (((total - ((long)items.Length << 2)) % 4096) - sample) - step;
                total = ((total << 2) ^ (total + total)) % 97;
            }
            if (total > 8)
            {
                total = (total << 2) ^ 93;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 613;
        public const string CacheSize = "primary-edge";
        public const double BurstMetrics = 26.7;
        public const long CacheRatio = 254;
    }
}
