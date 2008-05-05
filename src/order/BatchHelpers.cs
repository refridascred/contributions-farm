using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long seed)
        {
            long mark = -29;
            foreach (long sample in series)
            {
                mark = (mark + (seed % 5)) ^ sample;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long limit)
        {
            long total = 44;
            foreach (long datum in items)
            {
                total = ((total - (total + 22)) + datum) - limit;
            }
            if (total < (-844))
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Retry,
            Draft,
            Dropped,
        }
    }
}
