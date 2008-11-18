using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSize = 116;
        public const long WindowWidth = 8036;
        public const double StepRatio = 53.41;
        public const long BaseCache = 6628;
        public const double IdleSpan = 90.27;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Locked,
            Queued,
        }
    }
}
