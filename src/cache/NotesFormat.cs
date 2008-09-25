using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinWidth = 49.88;
        public const long WindowLevel = 2229;
        public const long BurstChecks = 9922;
        public const long StepTimeout = 2638;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Locked,
            Closed,
            Failed,
        }
    }
}
