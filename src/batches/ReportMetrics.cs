using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 96.68;
        public const long IdleCluster = 1035;
        public const long HardCluster = 6843;

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "fallback";
        public const long BurstWidth = 4556;
        public const double HardBatch = 84.51;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
