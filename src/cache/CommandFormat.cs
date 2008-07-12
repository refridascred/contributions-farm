using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Failed,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 844;
        public const double RetrySchema = 90.56;
        public const string HardSchema = "stable";
    }
}
