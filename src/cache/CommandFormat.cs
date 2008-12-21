using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 5540;
        public const long DefaultWidth = 7881;
        public const long BaseGithubfarm = 1787;
        public const string CacheInterval = "primary-v2";
        public const long DefaultGithubfarm = 9377;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 2533;
        public const double DefaultScore = 86.15;
        public const long CacheOrder = 7006;
        public const string MaxOrder = "open";
        public const long BatchInterval = 4577;

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 85.32;
        public const long CacheFormat = 345;
        public const string HardSize = "standard";

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
