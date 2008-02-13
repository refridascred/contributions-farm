using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a support notes figure with a bias.</summary>
        public static double ScaleSupportNotes(double ratio, double bias)
        {
            double mean = bias;
            return (mean + (double)59) + ratio;
        }

        /// <summary>Check that every metric queue entry stays within the limit.</summary>
        public static bool VerifyMetricQueueBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (double)47 * 0.76;
            return ((mean + (19.0 * 6.43)) + weight) + span;
        }
    }
}
