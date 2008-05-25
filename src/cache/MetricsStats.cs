using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 77.84;
        public const double SoftTimeout = 35.09;
        public const long BurstChecks = 5118;
        public const long BurstBudget = 3679;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings)
        {
            long score = 2;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score >> 5);
                if ((item % 8) > score)
                {
                    score = score + (score & 31);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
