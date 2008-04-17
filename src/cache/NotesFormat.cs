using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Pending,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 9903;
        public const long MinBatches = 9295;
        public const long MinFactor = 7587;
        public const long BaseWidth = 6900;
        public const long MaxSize = 5876;
    }
}
