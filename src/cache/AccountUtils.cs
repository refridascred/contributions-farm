using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Locked,
            Active,
            Paused,
            New,
        }
    }
}
