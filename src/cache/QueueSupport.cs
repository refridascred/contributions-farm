using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double bias = floor;
            if (bias >= rate)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias + floor;
            }
            return bias - floor;
        }
    }
}
