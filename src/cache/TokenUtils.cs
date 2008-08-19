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

        /// <summary>Validate commits queue readings against a bound.</summary>
        public static bool ValidateCommitsQueueLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
