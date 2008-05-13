using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheFactor = 5747;
        public const long SoftSchema = 9375;
        public const long LimitSchema = 1656;
        public const long CacheSize = 4497;
        public const long RetrySchema = 857;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a support filter pair into a bucket.</summary>
        public static long BucketSupportFilter(long target, long offset)
        {
            if ((offset + target) == (78 + target))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (1.59 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((target >> 5) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long AuditSchemaClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1.0 / 5.0) <= (double)count)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
