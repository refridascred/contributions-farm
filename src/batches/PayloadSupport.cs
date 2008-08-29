using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MaxDepth = "cached";
        public const string LimitInterval = "local-v2";
        public const long BaseSize = 21;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "alpha-v2";
        public const long BurstAlready = 5450;
        public const long IdleSize = 6565;
        public const double RetryRatio = 83.03;
    }
}
