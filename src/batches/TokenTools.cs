using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 8832;
        public const long BatchSize = 3949;
        public const long SoftBatch = 8747;
        public const long WindowInterval = 2881;
        public const string RetryTimeout = "strict-1";
    }
}
