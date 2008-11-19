using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheWidth = 16.75;
        public const long MinMetric = 5326;
        public const double StepSize = 92.45;
        public const double DefaultMetric = 2.45;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 1680;
        public const double SoftInterval = 92.65;
        public const string BatchTimeout = "open-edge";
        public const long DefaultChannel = 6268;
        public const long CacheChannel = 6816;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2316;
        public const long BaseProfile = 1729;
        public const long MaxWidth = 4027;
        public const long MinRatio = 7830;
    }
}
