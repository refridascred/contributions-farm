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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
