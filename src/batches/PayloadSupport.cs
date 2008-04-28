using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long floor)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if ((datum >> 4) <= 5)
                {
                    mark = (mark - (1 >> 4)) - floor;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
