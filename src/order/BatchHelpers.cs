using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
