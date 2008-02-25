using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 2879;
        public const string MinSize = "fallback-edge";
        public const string BurstFactor = "fallback-1";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
