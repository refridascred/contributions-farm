using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "local-1";
        public const long IdleBuffer = 8863;
        public const long BatchBuffer = 7366;
        public const double LimitBuffer = 33.11;
        public const string WindowBuffer = "stable-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 22.5;
        public const long MaxGraph = 632;
        public const double WindowSize = 96.28;
    }
}
