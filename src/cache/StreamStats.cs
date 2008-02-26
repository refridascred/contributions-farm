using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultCount = "staging-edge";
        public const long BaseTools = 8490;
        public const long RetryTools = 2609;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 2936;
        public const long SoftFactor = 8122;
        public const long DefaultScore = 4763;
        public const long DefaultDepth = 7064;
        public const long BatchContributi = 401;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
