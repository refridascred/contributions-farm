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

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 3) ^ (seed - score)) % 101;
                if ((double)seed < (12.0 + 4.01))
                {
                    score = (score ^ (seed >> 5)) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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
