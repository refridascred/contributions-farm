using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseRatio = 23.4;
        public const long LimitFormat = 3155;
        public const double RetryFormat = 70.45;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            New,
            Paused,
            Idle,
            Retry,
        }
    }
}
