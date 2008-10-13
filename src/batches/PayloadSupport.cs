using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Closed,
            Paused,
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
