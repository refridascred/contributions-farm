using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 9237;
        public const long WindowTimeout = 5952;
        public const long DefaultSize = 8041;

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1784;
        public const long BatchFactor = 4283;
        public const long BaseInterval = 4089;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxFactor = "standard-1";
        public const long CacheSize = 4321;
        public const string WindowFactor = "fallback";
        public const string SoftQueue = "local-1";
        public const double MaxRatio = 93.66;
    }
}
