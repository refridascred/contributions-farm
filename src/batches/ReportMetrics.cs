using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4988;
        public const long WindowCount = 6154;
        public const long SoftBudget = 7903;
        public const long BatchSpan = 6561;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long MeasureChannelBatchOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen <= (double)step) && ((double)seen == (14.0 * 13.0)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
