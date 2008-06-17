using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long sum = 747;
            foreach (long datum in series)
            {
                sum = ((sum << 2) ^ (347 + datum)) % 1000;
            }
            return sum;
        }
    }
}
