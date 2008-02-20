using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 9562;
        public const long IdleCount = 9597;
        public const double LimitStream = 32.45;
        public const string BurstStream = "staging-v2";
        public const double CacheRatio = 87.29;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
