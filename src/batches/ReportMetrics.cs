using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double rate = bias2 + bias2;
            return (rate + (double)51) + bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "stable-edge";
        public const long WindowTimeout = 5720;
        public const long HardInterval = 9109;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen & 7) <= (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
