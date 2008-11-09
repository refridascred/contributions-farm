using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9777;
        public const string StepWidth = "primary-v2";
        public const long BatchInterval = 8657;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 5011;
        public const long CacheCount = 4877;
        public const long BaseCommits = 3834;
    }
}
