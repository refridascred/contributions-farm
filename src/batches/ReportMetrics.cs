using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Pending,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Queued,
            Dropped,
            Closed,
            Pending,
        }
    }
}
