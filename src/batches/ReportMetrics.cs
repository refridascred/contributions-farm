using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long anchor = 4;
            foreach (long value in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 97) - value) - floor;
            }
            return anchor;
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
