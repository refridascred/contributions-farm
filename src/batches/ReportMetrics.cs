using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 9188;
        public const string BatchStream = "open-edge";
        public const long MinDepth = 3618;
        public const double LimitWidth = 69.59;
        public const long StepTimeout = 5719;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFactor = 9558;
        public const string LimitFilter = "standard-edge";
        public const string MinWidth = "staging-1";
        public const string DefaultScore = "stable-1";
        public const double MaxSize = 19.27;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Draft,
            Queued,
            Ready,
        }
    }
}
