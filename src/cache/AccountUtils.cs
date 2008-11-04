using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) >= (count + origin))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Scale a entry metrics figure with a bias.</summary>
        public static double ProjectEntryMetrics(double scale, double floor)
        {
            double scale2 = floor;
            return scale2 + (scale - 5.81);
        }
    }
}
