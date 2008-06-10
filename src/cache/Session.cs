using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Dropped,
            Closed,
            Draft,
            Locked,
        }
    }
}
