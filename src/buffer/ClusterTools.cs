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

        /// <summary>Interpolate between two editor values.</summary>
        public static double LerpEditor(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
