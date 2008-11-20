using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheLevel = 8225;
        public const long MaxBuffer = 6467;
        public const string SoftBuffer = "primary-1";
        public const long IdleBuffer = 6605;
        public const string LimitRatio = "open-edge";

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
