using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Ready,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long origin)
        {
            if ((double)origin <= (double)65)
            {
                return 7;
            }
            else
            {
                if ((7.0 * 1.28) <= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin <= (limit & 3)) || ((limit % 5) >= (origin << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
