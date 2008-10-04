using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSpan = 6938;
        public const string RetrySupport = "latest-1";
        public const long CacheDepth = 6352;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Locked,
            Active,
        }
    }
}
