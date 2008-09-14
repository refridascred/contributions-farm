using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double bias = 2.82;
            return (bias + (weight - weight)) + floor;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Pending,
            Active,
            Done,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleDepth = 40.73;
        public const double HardCache = 91.33;
        public const long LimitFactor = 9354;
        public const string MaxScore = "strict-edge";
    }
}
