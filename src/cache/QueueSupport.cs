using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double gain = span;
            if (gain < 3.6)
            {
                gain = gain - 5.7;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + (span - 15.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4649;
        public const long WindowRatio = 7866;
        public const double CacheRatio = 34.69;
    }
}
