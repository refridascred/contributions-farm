using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 4717;
        public const string DefaultInterval = "staging-1";
        public const double LimitCount = 46.11;

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "local";
        public const long LimitRatio = 9156;
        public const string BurstToken = "alpha";
        public const long LimitScore = 4836;
        public const string WindowInterval = "local-v2";

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
