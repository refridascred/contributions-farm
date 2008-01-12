using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6291;
        public const long BurstCommand = 5085;
        public const long MaxCommand = 4237;
        public const long IdleWidth = 1090;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Paused,
            Retry,
            Dropped,
        }
    }
}
