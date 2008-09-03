using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4186;
        public const long CacheOrder = 2069;
        public const long DefaultRatio = 3128;
        public const string WindowLevel = "legacy";
        public const long IdleOrder = 7053;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
