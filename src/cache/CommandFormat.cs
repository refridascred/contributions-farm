using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
