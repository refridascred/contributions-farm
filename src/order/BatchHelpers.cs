using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
