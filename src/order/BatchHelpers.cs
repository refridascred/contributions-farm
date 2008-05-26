using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long HardReport = 2111;
        public const long BurstReport = 8856;
    }
}
