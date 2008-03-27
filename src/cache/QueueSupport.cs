using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 4) + anchor;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double rate = ratio;
            if (rate >= (bias * 0.13))
            {
                rate = rate - (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (ratio * 2.93)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Retry,
            Pending,
            Ready,
        }
    }
}
