using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double ratio = (double)(31 + 3);
            return ((ratio + (ratio + ratio)) + scale) + bias;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (limit << 2))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5290;
        public const double CacheInterval = 92.0;
        public const long CacheLevel = 514;
    }
}
