using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitWidth = 7722;
        public const long LimitGithubfarm = 1840;
        public const long WindowRatio = 7907;
        public const string MaxSize = "open-edge";
        public const long IdleGithubfarm = 8715;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
