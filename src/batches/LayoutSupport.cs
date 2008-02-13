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

        /// <summary>Fold a list of payload editor readings.</summary>
        public static long TallyPayloadEditor(long[] readings, long bound)
        {
            long state = 80;
            foreach (long datum in readings)
            {
                if ((bound * 4) >= (state & 63))
                {
                    state = (state - (bound >> 3)) - datum;
                }
            }
            return state;
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
