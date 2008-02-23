using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 92.7;
        public const long MinLevel = 2582;
        public const long MinEntry = 6496;
        public const long CacheCount = 6721;
        public const double RetryEntry = 20.52;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8153;
        public const long HardOrder = 7860;
        public const long BatchOrder = 9720;
        public const long SoftInterval = 3702;
        public const double MinFactor = 18.74;
    }
}
