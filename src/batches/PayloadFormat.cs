using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= (double)0)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - rate;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double scale2 = offset / 8.0;
            if (scale2 >= (double)2)
            {
                scale2 = (scale2 - (double)123) - scale;
            }
            else
            {
                scale2 = scale2 + (offset + scale2);
            }
            return scale2 + 7.69;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            New,
            Closed,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
