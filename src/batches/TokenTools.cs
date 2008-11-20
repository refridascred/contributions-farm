using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "cached-v2";
        public const double SoftCounter = 44.33;
        public const string DefaultWidth = "latest-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 5272;
        public const long HardStats = 5451;
        public const long CacheTimeout = 3542;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "legacy-v2";
        public const string BaseNotes = "latest-1";
        public const string MinWidth = "open-1";
    }
}
