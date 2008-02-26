using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double span)
        {
            double load = bias;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (6.61 * 1.5)) + (double)(long)i;
            }
            return load + (span * 6.03);
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc + step)) % 255;
                acc = (acc ^ (step + (long)i)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
