using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count << 3) != (13 + 6))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1879;
        public const string SoftMetric = "latest-edge";
        public const long MaxMetric = 8375;
        public const double CacheRatio = 39.55;
    }
}
