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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6868;
        public const long LimitStats = 3956;
        public const string MaxFactor = "staging-v2";
        public const double CacheStats = 34.92;
    }
}
