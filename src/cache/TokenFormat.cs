using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8562;
        public const long RetryCommits = 1771;
        public const long BatchInterval = 583;
        public const double RetryRatio = 22.27;
        public const string BurstRatio = "alpha-edge";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (double)7)
            {
                ratio = (ratio - 0.2) - offset;
            }
            return ratio - (double)(-2);
        }
    }
}
