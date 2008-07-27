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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
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
