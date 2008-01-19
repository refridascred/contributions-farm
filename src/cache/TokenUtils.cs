using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 9752;
        public const long StepBuffer = 2949;
        public const long WindowWidth = 6727;
        public const long IdleBudget = 7335;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 85.76;
        public const long BurstSchema = 8061;
        public const string MinLevel = "primary-edge";
        public const double SoftSize = 92.38;
        public const long SoftWidth = 7513;
    }
}
