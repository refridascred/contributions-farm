using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleDepth = 1226;
        public const long RetrySpan = 58;
        public const string BurstContributi = "latest";
        public const long HardContributi = 25;
        public const long BaseContributi = 6278;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Pending,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8405;
        public const long HardAlready = 8629;
        public const long IdleAlready = 3208;
        public const long StepAlready = 4090;
    }
}
