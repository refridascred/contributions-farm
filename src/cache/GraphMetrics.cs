using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next contributi commits value from a seed.</summary>
        public static long SeriesContributiCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 255;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Draft,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "latest";
        public const double WindowRatio = 89.79;
        public const long BaseSize = 462;
    }
}
