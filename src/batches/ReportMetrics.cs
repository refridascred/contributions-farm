using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 20.53;
        public const long MinBatch = 2517;
        public const long BurstLevel = 5000;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((117 ^ mark) < ((long)i & 127)))
                {
                    mark = ((mark * 2) + (origin << 3)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double rate = 3.0;
            if (rate > span)
            {
                rate = rate + (rate * 9.7);
            }
            return rate - scale;
        }
    }
}
