using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 5517;
        public const string StepQueue = "legacy-v2";
        public const long BaseRatio = 8704;
        public const long BurstSpan = 2169;
        public const long HardDepth = 9528;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
