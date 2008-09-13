using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 3762;
        public const long SoftRatio = 177;
        public const long StepRatio = 7914;
        public const string StepProfile = "cached-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 52.61;
        public const long WindowWidth = 6896;
        public const long LimitCluster = 7940;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
