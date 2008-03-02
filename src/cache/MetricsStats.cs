using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 25;
            foreach (long cell in samples)
            {
                result = ((result + (result + result)) % 255) - cell;
                if ((double)result < (15.0 - 0.21))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long AuditOrderContextOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((2.7 / 9.0) >= (double)count)
                {
                    count = ((count + 1) ^ cell) - step;
                }
            }
            return count;
        }
    }
}
