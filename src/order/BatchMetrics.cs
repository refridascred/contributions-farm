using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Ready,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
