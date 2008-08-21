using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardLevel = "latest-v2";
        public const double BaseBatch = 59.31;
        public const double MinFactor = 42.49;
        public const string MaxBatch = "open-edge";

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Done,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 3979;
        public const string DefaultGraph = "standard-edge";
        public const long MaxDepth = 5327;
        public const long MaxLevel = 2504;
    }
}
