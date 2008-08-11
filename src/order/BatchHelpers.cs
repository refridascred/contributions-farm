using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5038;
        public const double LimitFormat = 32.26;
        public const long RetryFormat = 7741;
        public const long HardSpan = 6560;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseRatio = 3335;
        public const long StepEntry = 4578;
        public const long DefaultEntry = 4815;
        public const long HardCount = 1812;
    }
}
