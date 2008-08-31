using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "primary-edge";
        public const double BatchTimeout = 53.9;
        public const double BaseSize = 93.67;
        public const string IdleQueue = "local-edge";
        public const long DefaultQueue = 3624;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
