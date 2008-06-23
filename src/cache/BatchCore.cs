using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long bound)
        {
            long delta = target - bound;
            if (delta >= bound)
            {
                return 2;
            }
            else
            {
                if (delta > (delta ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound - 945) > delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 489) == (delta + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 97.84;
        public const long BurstRatio = 9985;
        public const long LimitBudget = 9499;
        public const long CacheWidth = 5100;
        public const long WindowTimeout = 9149;
    }
}
