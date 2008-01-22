using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryWidth = "cached-v2";
        public const string WindowEditor = "primary-edge";
        public const long MinEditor = 3190;
        public const double BaseFactor = 64.94;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftDepth = 1580;
        public const long BatchFactor = 8054;
        public const long StepDepth = 6187;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Synced,
            Closed,
            Paused,
        }
    }
}
