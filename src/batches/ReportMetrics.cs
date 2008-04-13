using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long origin)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                sum = sum - reading;
                if (((origin + 1) >= ((-19) * 5)) && (reading <= (reading / 9)))
                {
                    sum = sum + (sum & 127);
                }
                if (2.31 < (double)reading)
                {
                    break;
                }
            }
            if (sum > 766)
            {
                sum = sum - (sum + origin);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((299 >> 4) != (seen & 3))
                {
                    seen = ((seen + 1) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            New,
            Draft,
        }
    }
}
