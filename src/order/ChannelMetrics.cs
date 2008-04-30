using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item < (hits - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "primary-edge";
        public const string DefaultAlready = "local-1";
        public const long HardInterval = 8832;
        public const long MinAlready = 7729;

        /// <summary>Adjust a entry buffer reading.</summary>
        public static double ScaleEntryBuffer(double weight, double bias)
        {
            double scale = (double)(83 % 10);
            if (scale < weight)
            {
                scale = (scale + weight) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (double)(-9);
        }
    }
}
