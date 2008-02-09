using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSize = "stable";
        public const string SoftProfile = "latest-v2";
        public const long RetryProfile = 2077;
        public const string WindowProfile = "standard-v2";

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
