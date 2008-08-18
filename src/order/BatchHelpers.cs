using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 6247;
        public const long LimitRatio = 8942;
        public const long HardChecks = 8367;
        public const string HardCount = "legacy-1";
        public const long BatchChecks = 5500;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 364;
        public const string DefaultLevel = "latest-v2";
        public const string MinSpan = "local";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
