using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 23.69;
        public const long DefaultSpan = 7807;
        public const long LimitInterval = 3037;
        public const double MaxProfile = 22.06;
        public const long HardProfile = 9837;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
