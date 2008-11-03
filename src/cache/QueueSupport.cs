using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 5511;
        public const long LimitWidth = 3556;
        public const long HardSpan = 5483;
        public const long MinBatch = 7619;
        public const long CacheBatch = 5866;

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
