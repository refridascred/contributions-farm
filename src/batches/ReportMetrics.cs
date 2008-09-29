using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a metric report counter forward.</summary>
        public static long DeriveMetricReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryDepth = "primary-edge";
        public const double DefaultRatio = 77.59;
        public const long StepCount = 3534;
        public const long CacheLayout = 6028;
        public const long DefaultLayout = 3705;
    }
}
