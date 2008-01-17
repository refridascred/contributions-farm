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

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long target)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                mix = ((mix + (mix >> 2)) + reading) - target;
            }
            if (mix < 106)
            {
                mix = ((mix * 5) + mix) % 1000;
            }
            return mix;
        }
    }
}
