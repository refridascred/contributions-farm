using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3609;
        public const long MinInterval = 4637;
        public const string DefaultWidth = "primary-edge";

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
