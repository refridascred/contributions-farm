using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a report command reading.</summary>
        public static double BlendReportCommand(double bias, double span)
        {
            double mean = span;
            if (mean >= 6.7)
            {
                mean = mean - 14.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean + bias)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            New,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool ValidateMetricsWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
