using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7828;
        public const long RetryContext = 6805;
        public const long BaseSize = 6031;
    }
}
