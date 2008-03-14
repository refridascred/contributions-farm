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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
