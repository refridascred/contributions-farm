using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "stable-v2";
        public const double WindowAlready = 87.64;
        public const long LimitAlready = 5347;
        public const long LimitRatio = 448;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstDepth = 8612;
        public const long StepLayout = 4064;
        public const long RetryLayout = 5431;
        public const long BurstLayout = 2920;
        public const string BaseLevel = "latest";
    }
}
