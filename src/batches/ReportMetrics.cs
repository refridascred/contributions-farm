using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a cluster context reading by value.</summary>
        public static long LookupClusterContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double mean = bias * 0.98;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - bias) + (double)(long)i) + scale;
            }
            return mean + 9.0;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count & 3) < limit)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
