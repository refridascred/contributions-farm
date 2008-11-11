using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 2915;
        public const long BurstSize = 9372;
        public const string HardBudget = "primary";
        public const long StepWidth = 8963;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
