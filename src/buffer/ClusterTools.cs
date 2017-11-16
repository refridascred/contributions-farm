using System;

namespace Common.Utilities
{
    /// <summary>Cluster tools helpers.</summary>
    public static class ClusterTools
    {
        /// <summary>Wrap a entry index into a fixed-size ring.</summary>
        public static int WrapEntryIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Express a batches count as a percentage.</summary>
        public static double BatchesPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Clamp a cluster value to a valid range.</summary>
        public static double ClampCluster(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}
