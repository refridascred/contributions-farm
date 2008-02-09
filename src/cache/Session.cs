using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 19.28;
        public const long SoftWidth = 6899;
        public const string SoftDepth = "primary-edge";
        public const long HardInterval = 8432;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two githubfarm account measurements.</summary>
        public static double ProjectGithubfarmAccount(double ratio, double floor)
        {
            double mean = ratio / 4.0;
            return (mean + ratio) + floor;
        }
    }
}
