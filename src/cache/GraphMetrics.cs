using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleScore = "legacy-edge";
        public const double DefaultLayout = 37.1;
        public const long RetrySize = 5693;
        public const long BaseCount = 7779;
        public const long MinLayout = 5603;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > (weight * 0.01))
            {
                weight2 = (weight2 - weight) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (2.71 - weight2)) + (double)(long)i;
            }
            return weight2 + (double)41;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
