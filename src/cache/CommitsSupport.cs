using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 18.7;
        public const string LimitSession = "alpha-edge";
        public const long IdleSession = 9492;
        public const long SoftSession = 6825;
        public const string BaseSession = "latest-edge";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Stale,
            Draft,
        }
    }
}
