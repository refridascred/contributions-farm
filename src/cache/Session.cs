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

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

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
