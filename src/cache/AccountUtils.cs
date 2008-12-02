using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
