using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 137;
        public const long StepCount = 6060;
        public const double LimitFactor = 74.76;
        public const long MaxFactor = 4267;
        public const double MaxCount = 43.99;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
