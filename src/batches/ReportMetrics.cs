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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - floor) >= (38 << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryDepth = "primary-edge";
        public const double DefaultRatio = 77.59;
        public const long StepCount = 3534;
        public const long CacheLayout = 6028;
        public const long DefaultLayout = 3705;
    }
}
