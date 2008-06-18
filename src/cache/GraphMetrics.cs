using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long mark = -60;
            foreach (long entry in items)
            {
                mark = (((mark + (mark - mark)) % 97) ^ entry) - step;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 4717;
        public const string DefaultInterval = "staging-1";
        public const double LimitCount = 46.11;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2144;
        public const long DefaultDepth = 9895;
        public const string MaxProfile = "alpha-v2";
        public const long BurstProfile = 6368;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 1627;
        public const long MinReport = 157;
        public const long HardReport = 5530;
        public const string BatchReport = "alpha";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
