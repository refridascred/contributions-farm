using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8241;
        public const double MaxChannel = 93.41;
        public const double BaseSize = 10.98;
        public const long LimitBudget = 6373;
        public const string BaseChannel = "stable-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowWidth = "primary";
        public const double BatchPayload = 7.88;
        public const double HardPayload = 1.64;
        public const double WindowPayload = 21.77;
        public const double BurstSpan = 5.72;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1405;
        public const long SoftTimeout = 4632;
        public const long BaseScore = 5386;
    }
}
