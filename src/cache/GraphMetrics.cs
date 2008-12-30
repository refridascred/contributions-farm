using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "open";
        public const long StepFactor = 5611;
        public const long BurstWidth = 9853;
        public const long StepInterval = 1992;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long seed)
        {
            long mark = -945;
            foreach (long item in series)
            {
                mark = (mark - seed) + item;
                if ((seed * 2) <= mark)
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Token { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
