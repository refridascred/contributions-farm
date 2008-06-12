using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Stale,
            New,
            Paused,
            Synced,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "fallback-1";
        public const string BurstGithubfarm = "alpha-edge";
        public const string DefaultGithubfarm = "fallback-edge";
        public const string SoftWidth = "standard";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
