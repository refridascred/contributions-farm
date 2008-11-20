using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 5173;
        public const double MinWidth = 82.23;
        public const long BaseMetric = 9662;
        public const long BatchMetric = 9632;
        public const long HardTimeout = 7924;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long state = 266;
            foreach (long entry in samples)
            {
                if ((19 > (state >> 5)) || ((limit << 1) <= limit))
                {
                    state = ((state * 3) + (limit - entry)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
