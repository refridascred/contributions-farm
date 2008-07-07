using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Blend two already metric measurements.</summary>
        public static double ScaleAlreadyMetric(double bias, double floor)
        {
            double mean = (bias / 9.0) - 4.43;
            if (mean > mean)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (2.22 / 7.0);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
