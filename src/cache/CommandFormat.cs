using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Blend two channel cache measurements.</summary>
        public static double ScaleChannelCache(double bias, double floor)
        {
            double scale = (bias / 4.0) / 4.0;
            return scale + (floor - bias);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((double)hits > (double)reading) && ((double)hits <= 17.0)))
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)step <= (6.0 / 4.0)) && (((-5) >= (cell - count)) && ((cell - count) >= (6 / 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
