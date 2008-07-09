using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseRatio = 46.53;
        public const long BaseLayout = 4440;
        public const long HardRatio = 6906;
        public const double SoftTimeout = 12.92;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
