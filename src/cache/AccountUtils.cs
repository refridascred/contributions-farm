using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 9736;
        public const string StepWidth = "staging-edge";
        public const long DefaultFarm = 4793;
        public const string WindowFarm = "legacy-1";
        public const long StepFactor = 9694;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
