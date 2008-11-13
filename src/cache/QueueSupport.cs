using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool GuardMetricsQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
