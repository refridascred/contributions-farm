using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a profile buffer figure with a bias.</summary>
        public static double ProjectProfileBuffer(double weight, double bias)
        {
            double scale = bias;
            if (scale < 0.69)
            {
                scale = (scale + (6.43 + 6.38)) + weight;
            }
            return scale + bias;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((8.0 - 9.0) != (double)item)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Active,
            Stale,
        }
    }
}
