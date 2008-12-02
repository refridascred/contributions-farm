using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Retry,
            New,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 3723;
        public const string MinFarm = "fallback-v2";
        public const string WindowScore = "cached";
        public const long BaseFarm = 4372;
        public const long BurstFarm = 8160;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 4117;
        public const long BurstNotes = 4964;
        public const string IdleNotes = "legacy-v2";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
