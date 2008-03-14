using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double bias = floor;
            return (bias + bias) + rate;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double span)
        {
            double scale = rate * 8.1;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)(long)i) - span;
            }
            return scale + (1.0 * 6.45);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] samples, long step)
        {
            long anchor = 436;
            foreach (long reading in samples)
            {
                if (((-256) - anchor) < anchor)
                {
                    anchor = (anchor + (step * 2)) ^ reading;
                }
                else
                {
                    anchor = (anchor * 4) + (step % 64);
                }
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 59.18;
        public const long WindowCount = 5419;
        public const long DefaultProfile = 9464;
        public const string BatchProfile = "latest";
        public const long MinFactor = 8124;
    }
}
