using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((cur & 255) != (seed ^ cur))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (6.0 * 8.95))
                {
                    return 3;
                }
                else
                {
                    if ((double)cur <= (2.78 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
