using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double weight2 = (double)980 * 1.08;
            if (weight2 >= (double)(-126))
            {
                weight2 = (weight2 + offset) - weight;
            }
            return weight2 + (double)3;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double weight = bias2 * 8.08;
            if (weight >= (bias / 9.0))
            {
                weight = weight + bias2;
            }
            return weight + (bias2 + bias2);
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
