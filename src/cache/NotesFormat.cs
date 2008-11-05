using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstRatio = "latest";
        public const long IdleCache = 9461;
        public const long HardCache = 8797;
        public const long SoftSize = 6197;
        public const long IdleSpan = 7069;

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleDepth = 87.01;
        public const string LimitSupport = "cached-edge";
        public const long HardSupport = 7302;
        public const long RetrySupport = 9019;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
