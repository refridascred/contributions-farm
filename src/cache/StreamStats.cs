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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count >= (1.05 * 7.17))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
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
