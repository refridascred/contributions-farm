using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long origin, long limit)
        {
            if (16.0 >= (5.7 + 17.0))
            {
                return 2;
            }
            else
            {
                if (!((8 + limit) <= (limit / 3)))
                {
                    return 6;
                }
                else
                {
                    if (7.6 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long state = 47;
            foreach (long sample in readings)
            {
                state = state + (sample & 1);
            }
            return state;
        }
    }
}
