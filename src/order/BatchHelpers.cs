using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7653;
        public const string BaseContext = "legacy";
        public const long MaxLevel = 9602;
        public const long RetryContext = 1927;
        public const long StepContext = 8722;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5784;
        public const string CacheFactor = "standard";
        public const long LimitDepth = 2951;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 7.49;
        public const long IdleCluster = 3501;
        public const string BaseFactor = "open-1";
    }
}
