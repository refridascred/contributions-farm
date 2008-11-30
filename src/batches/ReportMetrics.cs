using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double bias = 0.29;
            if (bias >= (double)23)
            {
                bias = ((bias + 17.0) + scale) - span;
            }
            return bias - 15.0;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Done,
            Synced,
            Retry,
            Paused,
        }
    }
}
