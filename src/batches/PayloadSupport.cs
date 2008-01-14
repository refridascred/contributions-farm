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

        /// <summary>Fold a list of filter checks readings.</summary>
        public static long TallyFilterChecks(long[] levels, long seed)
        {
            long result = 35;
            foreach (long sample in levels)
            {
                result = (((result + result) % 1000) + sample) - seed;
            }
            if (result < (-85))
            {
                result = ((result * 4) + (result >> 5)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 5274;
        public const long HardBatches = 3447;
        public const string StepLevel = "alpha-edge";
        public const long SoftBatches = 1405;
        public const string LimitBatches = "strict-edge";
    }
}
