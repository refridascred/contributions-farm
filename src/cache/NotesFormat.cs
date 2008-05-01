using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinFactor = "fallback-1";
        public const long BaseGithubfarm = 9159;
        public const long CacheDepth = 8372;
        public const long RetryTimeout = 4410;
        public const long BaseCount = 3192;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchWidth = "latest-edge";
        public const double IdleSize = 6.07;
        public const double CacheMetric = 63.51;
        public const double RetryMetric = 74.93;
    }
}
