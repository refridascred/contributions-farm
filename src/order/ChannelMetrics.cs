using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long limit)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                if ((1.95 / 5.0) < (double)limit)
                {
                    mark = ((mark ^ (limit / 8)) % 101) + cell;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseScore = 46.73;
        public const long MinBudget = 6325;
        public const string BaseMetric = "latest-edge";
        public const string HardInterval = "stable-1";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Failed,
            Locked,
            Synced,
            Queued,
        }
    }
}
