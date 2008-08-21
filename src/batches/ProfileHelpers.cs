using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstFactor = 21.65;
        public const string MaxLayout = "staging-v2";
        public const string MinLayout = "strict-v2";
        public const double SoftScore = 59.87;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 8223;
        public const long LimitSchema = 6931;
        public const string CacheSchema = "latest-1";
        public const long BaseSchema = 9410;
        public const double WindowSchema = 46.6;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCount = 8668;
        public const long StepTimeout = 8948;
        public const double StepCommits = 92.9;
        public const string BatchSize = "fallback-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryDepth = 2521;
        public const string RetryGithubfarm = "legacy-v2";
        public const double DefaultGithubfarm = 4.4;
        public const long BatchGithubfarm = 5608;
    }
}
