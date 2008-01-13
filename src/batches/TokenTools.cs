using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double rate = (6.0 * 15.0) / 8.0;
            if (rate >= (rate + gain))
            {
                rate = (rate - (0.95 - gain)) + span;
            }
            return rate - (double)794;
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
