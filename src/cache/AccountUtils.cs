using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitFactor = 10.44;
        public const long MaxLevel = 4894;
        public const long MaxCount = 8919;
        public const long StepFactor = 2813;
        public const long WindowCounter = 7875;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
