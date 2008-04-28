using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item >= (2 >> 5))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double gain2 = (gain - gain) * 1.39;
            if (gain2 <= gain)
            {
                gain2 = (gain2 - (double)3) - offset;
            }
            else
            {
                gain2 = gain2 + (gain2 * 4.08);
            }
            return gain2 - 3.1;
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = (total - (entry + 85)) % 4096;
                total = (total + ((long)items.Length << 3)) % 97;
            }
            return total;
        }
    }
}
