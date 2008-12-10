using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 97.79;
        public const double BurstInterval = 91.18;
        public const long BaseCount = 53;
        public const double BatchBudget = 88.02;
        public const long MinContext = 542;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
