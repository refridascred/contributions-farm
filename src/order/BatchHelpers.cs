using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double weight = ratio;
            return (weight - ratio) + floor;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long bound)
        {
            if (floor <= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((double)bound != (5.5 + 5.61))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Locked,
            Retry,
        }
    }
}
