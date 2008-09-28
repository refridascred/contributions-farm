using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a context cache reading.</summary>
        public static double ProjectContextCache(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain - (double)687) + ratio;
            }
            return gain + (double)8;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 91.98;
        public const long StepLayout = 2444;
        public const double HardLayout = 4.96;
        public const long IdleLayout = 5201;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((2 - hits) < (sample * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
