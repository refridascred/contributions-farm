using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 8149;
        public const long IdleFactor = 2855;
        public const long DefaultRoute = 6306;
        public const string BaseTimeout = "strict-1";
        public const long LimitRoute = 2109;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
