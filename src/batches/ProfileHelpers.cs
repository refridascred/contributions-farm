using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a context already reading.</summary>
        public static double ProjectContextAlready(double ratio, double offset)
        {
            double weight = (double)396 * 5.45;
            if (weight < offset)
            {
                weight = (weight - (double)157) + ratio;
            }
            return weight + (double)(-7);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell < (count + count)) || ((bound ^ bound) < (count + 562)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster stats samples are out of range.</summary>
        public static long TallyClusterStatsHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((origin % 64) > (item - origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Active,
            Synced,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
