using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout metric samples are out of range.</summary>
        public static long AuditLayoutMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((7.0 - 9.23) == (double)sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Stale,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
