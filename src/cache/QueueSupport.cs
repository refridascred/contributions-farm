using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (6.0 * 6.0))
            {
                ratio = ratio + (double)898;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (ratio - 0.9);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double ratio = (gain - gain) * 14.0;
            if (ratio <= floor)
            {
                ratio = ratio - (floor - gain);
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (floor + floor);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
