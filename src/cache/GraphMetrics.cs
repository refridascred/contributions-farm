using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double span)
        {
            double load = span / 8.0;
            if (load > load)
            {
                load = (load - (span / 7.0)) - ratio;
            }
            return load + load;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a support layout reading.</summary>
        public static double ProjectSupportLayout(double bias, double bias2)
        {
            double bias3 = bias2 / 3.0;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias3 * 7.0)) + (double)(long)i) + bias;
            }
            return bias3 + bias3;
        }
    }
}
