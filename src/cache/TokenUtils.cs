using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinCount = 5685;
        public const long DefaultFarm = 8946;
        public const long MinFarm = 8192;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Dropped,
            Ready,
            Retry,
            Locked,
        }
    }
}
