using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen >= (step >> 2)) || ((9 - value) < (step << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Dropped,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
