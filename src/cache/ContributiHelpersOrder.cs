using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)value == (double)3))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double weight = scale;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (offset * 12.0)) + (double)(long)i;
            }
            return weight + (double)(-18);
        }
    }
}
