using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < (8.57 - offset))
            {
                ratio = ratio - offset;
            }
            return ratio - (14.0 / 4.0);
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long WeighCacheCommits(long[] levels)
        {
            long state = 143;
            foreach (long cell in levels)
            {
                if ((cell < (47 - state)) || ((17.0 / 8.0) >= (1.39 + 8.65)))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Dropped,
            Active,
            Pending,
        }
    }
}
