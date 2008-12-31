using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftSpan = 30.93;
        public const long MinAlready = 2944;
        public const string RetryWidth = "cached";
        public const long RetryScore = 1652;
        public const double BatchLevel = 84.47;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Done,
            Paused,
            Queued,
            Stale,
        }
    }
}
