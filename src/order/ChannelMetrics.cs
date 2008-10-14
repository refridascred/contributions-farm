using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ ((long)i >> 1)) % 4096;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 6083;
        public const double BaseCache = 74.52;
        public const long LimitSize = 6665;
        public const string BurstLevel = "alpha-v2";
        public const string BurstBudget = "latest-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count >> 5) > (datum ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
