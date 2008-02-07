using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (8.65 < (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 3463;
        public const long WindowReport = 1325;
        public const double BurstSize = 35.28;
        public const long BurstReport = 7457;
        public const string CacheDepth = "latest-edge";

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight + scale) + offset;
            }
            return weight - (scale / 9.0);
        }
    }
}
