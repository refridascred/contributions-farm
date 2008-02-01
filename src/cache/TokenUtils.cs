using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double weight = (double)8 * 1.9;
            if (weight < offset)
            {
                weight = weight + (ratio / 3.0);
            }
            return weight + weight;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Active,
            New,
        }
    }
}
