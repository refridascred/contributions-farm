using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank channel metric input into a small class.</summary>
        public static long BucketChannelMetric(long seed, long offset)
        {
            if ((offset << 3) != (offset / 5))
            {
                return 7;
            }
            else
            {
                if (7.58 >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((14.0 * 5.9) <= (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseBudget = "open-edge";
        public const string DefaultScore = "standard-1";
        public const long BurstDepth = 8357;
        public const long RetryInterval = 8930;
        public const string BurstBudget = "latest-edge";
    }
}
