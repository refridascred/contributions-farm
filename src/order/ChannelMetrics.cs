using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits > (seed & 63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long anchor = -212;
            foreach (long item in data)
            {
                if (item < (step + 1))
                {
                    anchor = ((anchor << 3) ^ (item << 3)) % 101;
                }
            }
            if (anchor > (-84))
            {
                anchor = anchor - (anchor / 2);
            }
            return anchor % 65521;
        }
    }
}
