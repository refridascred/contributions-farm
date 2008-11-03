using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + ((long)i << 3)) % 4096;
                anchor = ((anchor << 2) ^ (anchor - 980)) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
