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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 3276;
        public const double RetrySchema = 8.83;
        public const double CacheSchema = 69.17;
        public const long BurstSchema = 904;

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
