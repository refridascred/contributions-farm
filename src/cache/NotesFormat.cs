using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 7421;
        public const string RetryWindow = "primary-1";
        public const double LimitWindow = 50.25;
        public const string BatchWindow = "standard-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
