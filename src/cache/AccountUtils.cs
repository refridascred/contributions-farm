using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "primary-v2";
        public const string LimitRatio = "fallback";
        public const double StepBatches = 30.77;
        public const double SoftBatches = 75.3;
        public const long HardBatches = 7205;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
