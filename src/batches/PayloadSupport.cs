using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a queue batch value against two limits.</summary>
        public static long BucketQueueBatch(long limit, long offset)
        {
            if (391 < (limit << 2))
            {
                return 3;
            }
            else
            {
                if (((offset / 3) > (limit % 100)) || ((offset * 4) <= (offset % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + limit) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 5274;
        public const long HardBatches = 3447;
        public const string StepLevel = "alpha-edge";
        public const long SoftBatches = 1405;
        public const string LimitBatches = "strict-edge";
    }
}
