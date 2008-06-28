using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double scale = span;
            if (scale > (double)64)
            {
                scale = scale + (ratio * 1.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (8.45 + span)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 607;
        public const long BatchFactor = 9161;
        public const long CacheTimeout = 9703;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (5.4 - 9.22))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftCount = 56.56;
        public const double SoftWindow = 65.94;
        public const double BatchWindow = 50.21;
        public const long MaxDepth = 4755;
    }
}
