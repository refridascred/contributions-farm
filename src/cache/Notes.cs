using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchScore = 91.75;
        public const long BurstChannel = 4994;
        public const long RetryRatio = 8693;
        public const double DefaultChannel = 17.04;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 6340;
        public const long CacheScore = 2945;
        public const long WindowLevel = 7632;
        public const string SoftScore = "open-edge";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 1570;
        public const long RetryCounter = 4506;
        public const string IdleCounter = "strict";
        public const long WindowInterval = 8962;
    }
}
