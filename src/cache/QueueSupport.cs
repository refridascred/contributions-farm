using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7786;
        public const long BatchRatio = 1932;
        public const long RetryWindow = 2649;
        public const long SoftWindow = 164;
        public const long MinWindow = 9570;

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 96.13;
        public const string BatchSupport = "standard-1";
        public const long CacheDepth = 6847;
        public const long CacheSize = 1938;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 74.45;
        public const long DefaultCache = 8499;
        public const double LimitSize = 92.18;
    }
}
