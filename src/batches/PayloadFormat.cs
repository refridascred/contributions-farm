using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long origin)
        {
            if (origin > (target + origin))
            {
                return 8;
            }
            else
            {
                if ((860 + target) < (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((26 + target) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a farm report value against two limits.</summary>
        public static long ClassifyFarmReport(long offset, long seed)
        {
            if ((double)offset != (double)4)
            {
                return 4;
            }
            else
            {
                if ((offset % 100) >= offset)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long state = 80;
            foreach (long reading in data)
            {
                if (state < (state + state))
                {
                    state = (state - state) + reading;
                }
                if ((state - state) <= (state * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
