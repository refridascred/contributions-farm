using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 7743;
        public const long BurstSpan = 8729;
        public const string LimitSize = "cached";
        public const long StepSpan = 2545;
        public const double RetryCount = 66.02;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 9787;
        public const long CacheAccount = 7514;
        public const long StepAccount = 5024;
        public const long LimitAccount = 5385;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Active,
            Draft,
            Pending,
            Closed,
        }
    }
}
