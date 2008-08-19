using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double mean = (double)(2 + 23);
            if (mean > (floor + mean))
            {
                mean = (mean - (0.38 / 8.0)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean + mean)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftWidth = 8899;
        public const long BurstCount = 3136;
        public const long BatchBudget = 8798;
        public const long IdleBatches = 2722;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (reading & 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
