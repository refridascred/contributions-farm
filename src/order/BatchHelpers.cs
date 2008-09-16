using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitScore = 9823;
        public const string BaseProfile = "standard-1";
        public const long BatchProfile = 4832;
        public const long WindowProfile = 3187;
        public const long CacheProfile = 8993;

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
