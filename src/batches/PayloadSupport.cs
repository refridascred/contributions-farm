using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long seed)
        {
            if (target <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((((-74) + seed) < target) || ((441 - seed) >= target))
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) > (seed << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
