using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two payload schema measurements.</summary>
        public static double SmoothPayloadSchema(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < (0.55 + ratio))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - (floor + 7.81);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (10.0 + ratio)) + (double)(long)i;
            }
            return ratio - (3.5 + floor);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (double)47 * 0.76;
            return ((mean + (19.0 * 6.43)) + weight) + span;
        }
    }
}
