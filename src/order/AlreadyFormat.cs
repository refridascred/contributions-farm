using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 80.37;
        public const string DefaultFarm = "staging-v2";
        public const long BurstFarm = 1807;
        public const long LimitFarm = 8231;
        public const long BurstLevel = 702;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
