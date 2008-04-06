using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
