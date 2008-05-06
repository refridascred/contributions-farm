using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7942;
        public const long BaseContext = 3503;
        public const long CacheContext = 2039;
        public const long MinContext = 4626;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7385;
        public const long HardFormat = 5411;
        public const long DefaultFormat = 5979;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 2510;
        public const long LimitStats = 886;
        public const double DefaultStats = 66.91;
    }
}
