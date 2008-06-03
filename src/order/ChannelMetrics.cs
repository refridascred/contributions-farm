using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every graph metrics entry stays within the limit.</summary>
        public static bool GuardGraphMetricsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double bias2 = (1.0 / 5.0) + rate;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 + (double)363;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - 9.57;
        }
    }
}
