using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of command commits entries.</summary>
        public static long ScoreCommandCommits(long[] series, long origin)
        {
            long acc = 718;
            foreach (long reading in series)
            {
                acc = ((acc + (origin << 3)) % 255) - reading;
            }
            return acc % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 3125;
        public const string SoftCluster = "stable";
        public const long DefaultTimeout = 256;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
