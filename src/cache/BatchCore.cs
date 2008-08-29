using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2289;
        public const long LimitEditor = 3474;
        public const long DefaultEditor = 516;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "stable-edge";
        public const string StepInterval = "local-v2";
        public const string LimitContext = "latest-1";
        public const long MinFactor = 1555;
    }
}
