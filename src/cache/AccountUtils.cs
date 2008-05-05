using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double ratio = (double)((-981) * 4);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (floor / 4.0)) + (double)(long)i) + scale;
            }
            return ratio - (double)1;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
