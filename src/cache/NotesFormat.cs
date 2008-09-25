using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Done,
            Draft,
            Paused,
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
