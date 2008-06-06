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

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)0)
            {
                rate = (rate - bias) + scale;
            }
            return rate + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardSize = 33.31;
        public const long MinSize = 2386;
        public const double MinFactor = 48.65;
        public const long HardScore = 5005;
    }
}
