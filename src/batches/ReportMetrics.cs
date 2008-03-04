using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a schema command value against two limits.</summary>
        public static long ClassifySchemaCommand(long limit, long offset)
        {
            if (((7.66 / 3.0) > (double)offset) || ((limit % 12) < (limit - 97)))
            {
                return 3;
            }
            else
            {
                if ((offset + limit) < (limit / 5))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Draft,
            Active,
            Synced,
            Queued,
        }
    }
}
