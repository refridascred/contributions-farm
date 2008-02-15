using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSize = 8471;
        public const double StepWidth = 5.6;
        public const long BaseFactor = 4035;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
