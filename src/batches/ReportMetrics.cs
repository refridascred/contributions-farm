using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batch contributi samples are out of range.</summary>
        public static long AuditBatchContributiOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((6 <= count) || ((floor ^ count) > floor)) && (((value << 2) > (value + count)) || (((long)levels.Length * 5) < value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit command metrics readings against a rule.</summary>
        public static long AuditCommandMetricsOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((83 >> 1) != (sample >> 4)) && (9.13 < (double)limit)) || (seen < (sample << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
