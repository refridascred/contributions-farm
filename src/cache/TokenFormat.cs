using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7434;
        public const long MaxWidth = 827;
        public const long BurstBatches = 3668;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Ready,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
