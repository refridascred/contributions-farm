using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 2.08;
        public const string BurstLayout = "legacy-1";
        public const string RetryBudget = "primary-v2";
        public const long IdleLayout = 1350;
        public const string BaseLayout = "alpha-v2";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double bias, double bias2)
        {
            double weight = 14.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias - bias2)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
