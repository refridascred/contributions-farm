using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double weight2 = (double)916 + (floor / 3.0);
            return (weight2 - floor) + weight;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long floor)
        {
            long mix = 650;
            foreach (long item in levels)
            {
                mix = (((mix - 6) % 255) + item) + floor;
            }
            return mix;
        }
    }
}
