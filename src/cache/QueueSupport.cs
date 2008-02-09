using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            New,
            Locked,
            Queued,
        }
    }
}
