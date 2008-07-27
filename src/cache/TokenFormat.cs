using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double span)
        {
            double gain = (rate * 0.48) + (double)42;
            if (gain <= 16.0)
            {
                gain = (gain - gain) - span;
            }
            return gain + (gain - rate);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (473 > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
