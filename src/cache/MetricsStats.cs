using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the cluster farm entries that pass the check.</summary>
        public static long TallyClusterFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value << 3) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            if ((double)limit >= (12.0 + 1.0))
            {
                return 4;
            }
            else
            {
                if ((limit & 15) < 47)
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit >= 6.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((30 % 60) > limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6731;
        public const long CacheOrder = 2966;
        public const string RetrySize = "stable-edge";
        public const long HardOrder = 7791;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
