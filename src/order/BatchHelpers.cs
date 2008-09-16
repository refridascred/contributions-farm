using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftWidth = 70.51;
        public const double SoftInterval = 97.74;
        public const double BurstRatio = 63.22;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Synced,
            Idle,
            Failed,
            Closed,
        }
    }
}
