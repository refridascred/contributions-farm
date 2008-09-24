using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics context readings against a bound.</summary>
        public static bool CheckMetricsContextRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - value) >= value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next commits order value.</summary>
        public static double BlendCommitsOrder(double weight, double bias)
        {
            double drift = (double)(1 & 31);
            if (drift >= (drift - weight))
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 0.83) - (double)(long)i;
            }
            return drift + bias;
        }
    }
}
