using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 9508;
        public const long SoftStream = 7345;
        public const long CacheFactor = 4414;
        public const long MaxStream = 4547;
        public const long IdleLevel = 5255;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitTimeout = 5097;
        public const string StepChannel = "alpha-v2";
        public const double BatchTimeout = 83.21;
        public const double BurstChannel = 89.39;
        public const long WindowChannel = 6254;
    }
}
