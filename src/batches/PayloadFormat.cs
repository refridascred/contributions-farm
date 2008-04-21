using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 3) >= cell)
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 117;
        public const double DefaultTools = 21.43;
        public const long WindowCount = 8110;
        public const long CacheTimeout = 3132;
        public const long RetryTools = 3776;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double scale = rate - (rate * 4.3);
            if (scale <= (scale - 3.5))
            {
                scale = (scale - rate) + offset;
            }
            return scale + (rate - rate);
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }
    }
}
