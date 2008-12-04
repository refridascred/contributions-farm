using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 5.35;
        public const long WindowAlready = 9128;
        public const long BatchAlready = 7981;
        public const long WindowRatio = 5121;
        public const long BurstAlready = 5051;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = floor;
            if (weight >= 6.0)
            {
                weight = weight - (floor - rate);
            }
            return weight - (weight - rate);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((8 + origin) < 223)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
