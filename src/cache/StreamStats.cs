using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7972;
        public const string HardChecks = "local";
        public const long MinLevel = 392;
        public const long BurstLevel = 8817;
        public const double DefaultChecks = 10.33;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftLevel = 1.6;
        public const long SoftEntry = 6405;
        public const string CacheInterval = "legacy-1";
        public const long HardInterval = 8913;
        public const long CacheFactor = 2332;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
