using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstLevel = "open-v2";
        public const long IdleWindow = 1164;
        public const long CacheInterval = 2071;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Closed,
            Done,
            Active,
        }
    }
}
