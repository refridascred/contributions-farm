using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit already batch readings against a rule.</summary>
        public static long TallyAlreadyBatchHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)bound < (3.2 / 7.0))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 6908;
        public const double BaseMetric = 4.38;
        public const double HardCount = 70.04;
        public const long BurstTimeout = 1378;

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
