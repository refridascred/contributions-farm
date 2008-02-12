using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 3396;
        public const long RetryQueue = 6845;
        public const double DefaultSpan = 41.17;
        public const double MinSpan = 30.55;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
