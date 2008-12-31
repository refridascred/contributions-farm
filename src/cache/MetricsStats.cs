using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Active,
            New,
            Synced,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((seed * 2) < (step + step))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) >= (step + seed)))
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
}
