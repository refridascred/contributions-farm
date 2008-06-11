using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7801;
        public const long DefaultStats = 9044;
        public const string IdleStats = "standard-edge";
        public const long DefaultSpan = 8514;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitSize = 90.27;
        public const double BurstBudget = 36.57;
        public const long WindowAlready = 6414;
        public const long BaseTimeout = 6978;
        public const long HardTimeout = 2917;
    }
}
