using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Paused,
            New,
            Retry,
            Done,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 1) <= (value - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many support profile samples are out of range.</summary>
        public static long AuditSupportProfileOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((7.2 + 1.7) > (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
