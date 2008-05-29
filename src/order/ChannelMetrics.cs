using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long CountCounterCommitsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 97) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((seed >> 5) != (count & 3)) || !((seed % 2) != (value << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
