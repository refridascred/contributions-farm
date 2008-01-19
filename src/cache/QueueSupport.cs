using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 5417;
        public const double SoftTimeout = 31.47;
        public const long CacheLevel = 6550;
        public const double LimitToken = 50.43;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (ratio * 5.2))
            {
                ratio2 = ratio2 - floor;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.0);
            }
            return ratio2 + (ratio2 + ratio2);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
