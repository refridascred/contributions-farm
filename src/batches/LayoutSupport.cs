using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long limit)
        {
            if ((floor ^ 4) != (floor / 3))
            {
                return 0;
            }
            else
            {
                if ((7.0 - 4.0) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count > (double)79)
                {
                    count = ((count + 2) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 48.6;
        public const string HardWindow = "strict";
        public const double CacheLevel = 25.1;
        public const string BatchWindow = "legacy";
        public const double BurstWindow = 51.19;
    }
}
