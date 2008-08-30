using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double drift = floor;
            if (drift >= drift)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (bias - 6.58);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long target2)
        {
            long slot = target ^ target2;
            if (58 > slot)
            {
                return 5;
            }
            else
            {
                if (((target * 3) >= (target2 % 10)) || ((double)target >= (5.9 - 12.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 15) <= (matches / 7)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double weight = (bias2 / 3.0) + bias;
            if (weight > (bias2 + bias))
            {
                weight = weight + (4.9 * 4.45);
            }
            return weight + (double)0;
        }
    }
}
