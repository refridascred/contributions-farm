using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 29.58;
        public const long MinRecord = 6554;
        public const long BatchRecord = 5952;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 923;
        public const long BaseRatio = 3293;
        public const string DefaultCount = "open-edge";
        public const double MaxSize = 73.83;
        public const string CacheScore = "strict-edge";
    }
}
