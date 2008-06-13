using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen << 3) > (seen >> 3))
                {
                    seen = ((seen + 3) + value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultInterval = "standard-v2";
        public const long WindowStats = 9727;
        public const double MinWidth = 94.68;
        public const string MinStats = "stable-edge";
        public const double CacheSpan = 68.58;

        /// <summary>Blend two report payload measurements.</summary>
        public static double BlendReportPayload(double rate, double bias)
        {
            double mean = rate;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)5;
        }
    }
}
