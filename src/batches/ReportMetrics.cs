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

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6373;
        public const long CacheSpan = 5854;
        public const string CacheFactor = "stable-edge";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
