using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "legacy-1";
        public const long MinSpan = 9619;
        public const double StepTools = 24.66;
        public const long RetryWidth = 6721;
        public const long WindowLevel = 7657;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-v2";
        public const long StepSize = 9902;
        public const long BatchNotes = 737;
        public const long IdleNotes = 9814;
    }
}
