using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 2) ^ (2 % 16)) % 101;
                if (!((8.9 * 0.8) >= (double)offset))
                {
                    total = ((total << 2) ^ (offset + total)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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
