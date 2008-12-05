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

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long score = 210;
            foreach (long item in values)
            {
                score = (((score << 3) ^ score) % 65521) ^ item;
            }
            if (score > 307)
            {
                score = (score - (bound / 9)) % 97;
            }
            return score % 65521;
        }

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
