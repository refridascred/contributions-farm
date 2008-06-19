using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double rate = 9.48;
            if (rate <= (double)434)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (bias / 8.0)) + (double)(long)i;
            }
            return rate - (weight * 6.3);
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 2) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
