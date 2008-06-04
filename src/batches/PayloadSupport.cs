using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double scale = (double)((-37) * 3);
            if (scale > 2.0)
            {
                scale = ((scale + scale) - rate) + offset;
            }
            else
            {
                scale = scale - 8.35;
            }
            return scale + scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryScore = "local";
        public const long BatchScore = 1692;
        public const string CacheCount = "stable-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((107 * 5) == (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
