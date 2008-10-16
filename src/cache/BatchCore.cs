using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next cluster githubfarm value from a seed.</summary>
        public static long StepClusterGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowCount = "fallback-1";
        public const long SoftFactor = 2539;
        public const long IdleAccount = 6873;
        public const double StepTimeout = 90.51;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 6831;
        public const long CacheTimeout = 4793;
        public const double BurstTimeout = 51.07;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
