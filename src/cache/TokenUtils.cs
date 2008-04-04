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

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3406;
        public const long MinFormat = 2771;
        public const double RetryInterval = 57.37;
        public const long IdleFormat = 1433;
    }
}
