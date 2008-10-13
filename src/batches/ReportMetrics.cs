using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long mix = 83;
            foreach (long value in samples)
            {
                if ((((-136) & 1) >= value) || ((value >> 2) < mix))
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                else
                {
                    mix = mix ^ value;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 8) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Pending,
            Draft,
            Locked,
            Queued,
        }
    }
}
