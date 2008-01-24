using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Failed,
            Queued,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinWidth = 82.69;
        public const long BurstCommand = 8010;
        public const long WindowLevel = 4293;
        public const long StepCommand = 9914;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Closed,
            Synced,
            Active,
        }
    }
}
