using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 4616;
        public const string HardLayout = "cached-edge";
        public const double WindowCount = 59.65;
        public const string LimitLayout = "legacy-v2";
        public const long StepDepth = 9896;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 8045;
        public const long SoftDepth = 9521;
        public const string StepWidth = "local-v2";
        public const long BurstSpan = 9154;
        public const long DefaultWidth = 3398;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 93.2;
        public const string WindowRatio = "staging-1";
        public const long BatchRatio = 3643;
        public const string MaxChecks = "local-v2";
        public const long LimitInterval = 1692;
    }
}
