using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1274;
        public const long LimitBudget = 1717;
        public const long DefaultContext = 8309;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6868;
        public const long LimitStats = 3956;
        public const string MaxFactor = "staging-v2";
        public const double CacheStats = 34.92;
    }
}
