using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)5)
            {
                ratio = (ratio + scale) + offset;
            }
            else
            {
                ratio = ratio + (double)520;
            }
            return ratio + (ratio * 4.42);
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
