using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ProjectSchemaCounter(double bias, double bias2)
        {
            double mean = 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + bias2) + (double)(long)i) - bias;
            }
            return mean + (bias2 - bias2);
        }
    }
}
