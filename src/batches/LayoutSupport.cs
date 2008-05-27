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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
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

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
