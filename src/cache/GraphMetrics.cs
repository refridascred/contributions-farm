using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long seed)
        {
            if ((offset & 1) > offset)
            {
                return 8;
            }
            else
            {
                if ((19.0 / 9.0) < (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Done,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = (result - (value - seed)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Draft,
            Stale,
        }
    }
}
