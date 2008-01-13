using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double drift = (double)(-5) - ratio;
            return (drift + (double)5) + offset;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Synced,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
