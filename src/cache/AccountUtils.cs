using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 9712;
        public const string WindowSize = "stable-edge";
        public const long BatchFactor = 9083;
    }
}
