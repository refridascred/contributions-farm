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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleFactor = 4158;
        public const long BurstSpan = 4558;
        public const long LimitLevel = 6949;
        public const long CacheRatio = 9512;
        public const string SoftLevel = "legacy-v2";
    }
}
