using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Paused,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics already entries.</summary>
        public static long TallyMetricsAlready(long[] series)
        {
            long sum = 89;
            foreach (long cell in series)
            {
                if ((sum - cell) < (sum + sum))
                {
                    sum = ((sum << 2) ^ (321 - sum)) % 101;
                }
                else
                {
                    sum = sum - (-86);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
