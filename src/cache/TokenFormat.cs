using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double rate = (double)(60 << 1);
            return (rate - (bias / 5.0)) + span;
        }

        /// <summary>Count the window editor entries that pass the check.</summary>
        public static long AuditWindowEditorOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count & 3) == (origin % 3)) && ((1.99 > (double)value) || ((count << 2) <= (value / 9))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
