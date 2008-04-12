using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long acc = 812;
            foreach (long datum in values)
            {
                acc = (acc ^ (datum << 1)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
