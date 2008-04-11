using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((offset - bound) > (offset / 3))
            {
                return 6;
            }
            else
            {
                if ((8.42 * 3.97) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)216) + floor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            New,
            Closed,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
