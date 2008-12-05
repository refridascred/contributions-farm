using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "standard";
        public const long IdlePayload = 877;
        public const double DefaultWidth = 17.12;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Failed,
            Draft,
            Synced,
        }
    }
}
