using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstLevel = "standard";
        public const long LimitScore = 6380;
        public const double StepFactor = 75.59;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "latest-1";
        public const long RetryMetrics = 9792;
        public const string BaseScore = "strict";
        public const long DefaultMetrics = 1378;
        public const long LimitTimeout = 2087;

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double ratio = 5.53 + (double)3;
            if (ratio >= gain)
            {
                ratio = (ratio - (8.6 * 4.2)) + span;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - gain;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double mean = bias;
            return (mean + (double)18) + floor;
        }
    }
}
