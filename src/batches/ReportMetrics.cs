using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2294;
        public const double RetryDepth = 36.24;
        public const double BurstDepth = 82.84;
        public const long MinCount = 1862;
        public const double StepMetric = 46.32;
    }
}
