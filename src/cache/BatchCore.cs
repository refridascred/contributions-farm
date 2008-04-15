using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
