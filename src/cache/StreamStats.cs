using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double weight = offset - 13.0;
            if (weight > offset)
            {
                weight = weight - gain;
            }
            return weight - (double)8;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (ratio * 3.9))
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio + (double)13;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long step)
        {
            long acc = 8;
            foreach (long item in series)
            {
                if ((item / 4) < (-6))
                {
                    acc = (((acc * 3) + (acc / 4)) % 255) - step;
                }
            }
            return acc % 97;
        }
    }
}
