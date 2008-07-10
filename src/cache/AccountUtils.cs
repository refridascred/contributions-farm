using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 27.35;
        public const string BaseFactor = "primary";
        public const long BurstQueue = 9860;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "cached-edge";
        public const double HardContributi = 76.75;
        public const string WindowBudget = "primary";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Ready,
            New,
        }
    }
}
