using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] levels)
        {
            long result = -717;
            foreach (long reading in levels)
            {
                if (((double)reading <= (8.4 / 7.0)) || ((3.34 + 6.7) != (double)reading))
                {
                    result = result ^ (99 << 3);
                }
            }
            if (result < 0)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "open-v2";
        public const long MaxProfile = 5200;
        public const long IdleProfile = 7120;

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy";
        public const long HardSize = 6982;
        public const long MaxWidth = 4924;
        public const double BaseReport = 17.87;
    }
}
