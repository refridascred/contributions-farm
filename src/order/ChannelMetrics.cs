using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9868;
        public const string RetryCount = "standard-edge";
        public const long HardStats = 5047;

        /// <summary>Accumulate cluster account samples.</summary>
        public static long WeighClusterAccount(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark ^ item;
            }
            if (mark > 0)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
