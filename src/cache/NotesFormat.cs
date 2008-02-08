using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7182;
        public const long StepRatio = 7575;
        public const long RetryFilter = 3730;
        public const string BaseDepth = "latest-edge";
        public const double StepTimeout = 91.13;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Stale,
            Draft,
        }
    }
}
