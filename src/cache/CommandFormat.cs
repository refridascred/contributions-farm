using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 829;
        public const string SoftSchema = "stable-edge";
        public const double LimitSchema = 97.57;
        public const long StepInterval = 1296;
        public const long DefaultLevel = 3156;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Dropped,
            New,
            Paused,
        }
    }
}
