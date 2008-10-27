using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double drift = bias + (bias - bias);
            return (drift + bias) + rate;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 9767;
        public const long IdleEntry = 5460;
        public const string WindowSize = "local-1";
        public const long HardSize = 8997;
        public const double LimitEntry = 1.83;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((-5) + 0) >= reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
