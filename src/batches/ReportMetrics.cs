using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a channel metric sample.</summary>
        public static long FindChannelMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinInterval = "primary-v2";
        public const double CacheLayout = 66.18;
        public const long MinLayout = 1451;

        /// <summary>Fold a list of report counter readings.</summary>
        public static long TotalReportCounter(long[] values)
        {
            long carry = 1;
            foreach (long value in values)
            {
                if (((double)value <= (5.9 / 4.0)) || (value >= carry))
                {
                    carry = carry - (value % 97);
                }
            }
            if (carry < (-47))
            {
                carry = carry - (carry % 8);
            }
            return carry;
        }
    }
}
