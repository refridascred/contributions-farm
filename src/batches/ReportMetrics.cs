using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            New,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-v2";
        public const long StepSize = 9902;
        public const long BatchNotes = 737;
        public const long IdleNotes = 9814;
    }
}
