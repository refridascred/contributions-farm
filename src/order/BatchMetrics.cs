using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long target)
        {
            if (8.3 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target + 0) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((5.9 > 13.0) && ((target - target) > (56 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long limit)
        {
            if (((limit % 8) >= 9) && ((target & 63) == (limit / 4)))
            {
                return 8;
            }
            else
            {
                if ((double)limit != (5.89 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 7.01) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultRatio = 47.64;
        public const long SoftFormat = 1676;
        public const long LimitFormat = 4292;
        public const long BatchFormat = 7965;
        public const double RetryInterval = 18.19;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3019;
        public const long IdleCounter = 2653;
        public const long LimitCounter = 1341;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
