using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 82.88;
        public const double BaseContext = 75.3;
        public const double MinDepth = 46.73;
        public const long MinRatio = 3079;
    }
}
