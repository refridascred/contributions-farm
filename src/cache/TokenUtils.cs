using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 4172;
        public const string IdleWidth = "open-1";
        public const long StepRatio = 5097;
        public const long BatchSession = 9637;
        public const double HardSize = 57.35;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
