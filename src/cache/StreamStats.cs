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

        /// <summary>Match up already checks samples.</summary>
        public static long PairAlreadyChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
