using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 81.35;
        public const long CacheTimeout = 3358;
        public const double StepSpan = 1.32;
        public const long CacheInterval = 4780;
        public const string MaxAccount = "stable-edge";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
