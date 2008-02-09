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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
