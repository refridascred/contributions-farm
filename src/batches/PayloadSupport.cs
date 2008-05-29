using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 73.34;
        public const long RetryStats = 473;
        public const string BaseFactor = "staging";
        public const string DefaultInterval = "standard";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxRatio = 64.79;
        public const double SoftGithubfarm = 37.02;
        public const long BurstSpan = 7663;
        public const long CacheRatio = 1592;
    }
}
