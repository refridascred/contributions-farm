using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 3227;
        public const string IdleSchema = "stable-v2";
        public const long BaseSchema = 47;
        public const long SoftSchema = 3504;
    }
}
