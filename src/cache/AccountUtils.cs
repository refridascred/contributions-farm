using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 2695;
        public const double MaxRatio = 92.48;
        public const long DefaultCommand = 6592;
        public const long BaseInterval = 4968;
        public const long DefaultLevel = 5051;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Active,
            Dropped,
            New,
        }
    }
}
