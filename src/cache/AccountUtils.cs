using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Done,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Paused,
            Locked,
            Failed,
        }
    }
}
