using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2323;
        public const long DefaultAccount = 3472;
        public const string WindowAccount = "stable-v2";
        public const long BaseAccount = 2130;
        public const long SoftAccount = 4715;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryScore = 24.17;
        public const long StepInterval = 6352;
        public const string BurstSpan = "alpha-edge";
        public const string MaxDepth = "legacy";
        public const string MaxWidth = "standard";
    }
}
