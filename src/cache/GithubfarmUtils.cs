using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7214;
        public const double HardReport = 43.69;
        public const long CacheDepth = 3789;
        public const long HardSpan = 1477;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 50.55;
        public const long MinBatches = 2427;
        public const double StepInterval = 82.64;
        public const long SoftBatches = 8969;
        public const string IdleRatio = "primary";
    }
}
