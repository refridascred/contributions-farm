using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheInterval = 3621;
        public const double IdleCache = 46.34;
        public const string BurstCache = "local";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
