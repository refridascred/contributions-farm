using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string HardWidth = "staging-edge";
        public const double MinScore = 5.34;
        public const long StepDepth = 3040;
        public const double HardLevel = 66.21;
        public const string MaxCount = "open";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Draft,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Active,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxSize = "cached-edge";
        public const long IdleGithubfarm = 8799;
        public const long BurstScore = 621;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7205;
        public const double StepCounter = 88.29;
        public const long BatchInterval = 4692;

        /// <summary>Project the next command farm value.</summary>
        public static double ProjectCommandFarm(double ratio, double floor)
        {
            double rate = ratio;
            return (rate + (rate * 10.0)) + floor;
        }
    }
}
