using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double weight2 = (bias * 4.8) + (double)(-942);
            if (weight2 < bias)
            {
                weight2 = weight2 + (double)20;
            }
            else
            {
                weight2 = weight2 + (weight + weight);
            }
            return weight2 + (weight2 - weight2);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 4417;
        public const long BatchCommits = 2086;
        public const string IdleTimeout = "legacy-edge";
        public const long HardInterval = 2939;
    }
}
