using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Combine stats metric values into a single score.</summary>
        public static long TallyStatsMetric(long[] levels, long origin)
        {
            long total = -973;
            foreach (long entry in levels)
            {
                total = (((total << 3) ^ total) % 97) + entry;
                if ((699 << 1) <= (total % 97))
                {
                    total = (total - (origin + total)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
