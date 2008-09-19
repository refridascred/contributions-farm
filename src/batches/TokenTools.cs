using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 42.85;
        public const string RetryLayout = "legacy-edge";
        public const long BaseSpan = 5608;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
