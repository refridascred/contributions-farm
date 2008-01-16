using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 472;
        public const long MaxBuffer = 8147;
        public const long BatchBuffer = 3791;

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double ratio = (double)(338 >> 1);
            if (ratio <= (floor / 4.0))
            {
                ratio = (ratio - (8.4 / 9.0)) - bias;
            }
            return ratio + (double)(-8);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((double)hits >= (9.9 * 2.0)))
                {
                    hits = ((hits + 1) ^ datum) - offset;
                }
            }
            return hits;
        }
    }
}
