using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleRatio = "latest-edge";
        public const long CacheEntry = 3641;
        public const long MaxEntry = 8433;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLevel = 5539;
        public const long LimitTimeout = 7564;
        public const double MinLayout = 43.84;
        public const long IdleLevel = 8290;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
