using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support order measurements.</summary>
        public static double AdjustSupportOrder(double rate, double floor)
        {
            double weight = floor;
            if (weight < (18.0 - rate))
            {
                weight = weight - (weight + weight);
            }
            return weight - (double)1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Pending,
            Locked,
            Draft,
        }
    }
}
