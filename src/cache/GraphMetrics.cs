using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 104;
        public const long StepBatches = 3898;
        public const string BatchBatches = "standard-v2";
        public const double BaseBatches = 45.0;
        public const string CacheRatio = "legacy-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 18.28;
        public const string DefaultGithubfarm = "staging";
        public const long BatchGithubfarm = 8996;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long sum = 17;
            foreach (long entry in items)
            {
                sum = (sum << 3) ^ (entry + entry);
                if (10.0 <= (double)sum)
                {
                    sum = (sum ^ (sum >> 2)) % 255;
                }
            }
            return sum % 4096;
        }
    }
}
