using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 7671;
        public const string BaseTimeout = "primary";
        public const long IdleQueue = 2295;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
