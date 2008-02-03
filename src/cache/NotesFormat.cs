using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultInterval = 13.36;
        public const long BurstScore = 3975;
        public const long CacheSpan = 1536;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryLevel = 942;
        public const long IdleTools = 7072;
        public const long CacheTools = 5498;
        public const double SoftTools = 62.63;
        public const long BaseTools = 6367;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
