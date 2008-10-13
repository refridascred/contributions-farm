using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
