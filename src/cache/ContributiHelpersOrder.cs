using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
