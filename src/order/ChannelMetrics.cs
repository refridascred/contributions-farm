using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double mean = offset;
            if (mean >= gain)
            {
                mean = mean + (mean + offset);
            }
            else
            {
                mean = mean - 15.0;
            }
            return mean + (double)336;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - seen) <= value)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
