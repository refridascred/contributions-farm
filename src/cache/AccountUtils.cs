using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultFactor = 1977;
        public const long BatchFactor = 1412;
        public const long WindowWidth = 1393;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9250;
        public const long MaxGraph = 8767;
        public const string RetrySpan = "primary-v2";
    }
}
