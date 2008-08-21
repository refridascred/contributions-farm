using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 680;
        public const long SoftDepth = 7086;
        public const string CacheSchema = "latest";
        public const string StepSpan = "latest-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchFactor = 654;
        public const string WindowCount = "standard-edge";
        public const long WindowSpan = 1416;
        public const string WindowLevel = "alpha-1";
    }
}
