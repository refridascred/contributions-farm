using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 3779;
        public const long BatchSession = 4489;
        public const string WindowSpan = "primary-edge";
    }
}
