using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double load = (double)23;
            return (load + (offset * 5.48)) + bias;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
