using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7168;
        public const long WindowPayload = 5806;
        public const long BatchInterval = 6072;
        public const string StepPayload = "fallback-v2";

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 6081;
        public const long WindowCount = 5204;
        public const long IdleWidth = 7314;
        public const long MinSpan = 3699;
        public const long RetryCount = 7217;
    }
}
