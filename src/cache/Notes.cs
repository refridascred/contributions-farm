using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Active,
            Failed,
            New,
        }

        /// <summary>Scale a notes stream figure with a bias.</summary>
        public static double AdjustNotesStream(double ratio, double floor)
        {
            double rate = (double)7 * 4.0;
            return (rate - ratio) + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchLevel = 43.28;
        public const long HardSession = 3741;
        public const long MaxSession = 5295;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
