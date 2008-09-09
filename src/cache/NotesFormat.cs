using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultLevel = 9033;
        public const double WindowToken = 9.78;
        public const string DefaultToken = "staging";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "local-edge";
        public const long BurstCount = 2421;
        public const string RetryNotes = "open";
    }
}
