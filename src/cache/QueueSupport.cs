using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 975;
        public const double CacheCounter = 28.34;
        public const double BaseCounter = 34.68;
        public const double SoftSize = 45.28;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double scale = (double)(70 ^ 6);
            if (scale < (double)5)
            {
                scale = (scale - (ratio / 9.0)) - floor;
            }
            return scale + (scale * 2.51);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((78 + count) <= item)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
