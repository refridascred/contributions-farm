using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = (bias / 8.0) / 8.0;
            if (bias2 > (bias2 + bias))
            {
                bias2 = bias2 - (floor + bias2);
            }
            else
            {
                bias2 = bias2 - (double)(-60);
            }
            return bias2 + 8.93;
        }

        /// <summary>Derive the next account contributi value from a seed.</summary>
        public static long SeriesAccountContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double floor)
        {
            double load = (double)(-8) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (weight - load)) + (double)(long)i) + floor;
            }
            return load + weight;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long datum in values)
            {
                if ((6 < offset) && ((double)offset != (double)datum))
                {
                    anchor = (anchor << 3) ^ (offset + offset);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + offset;
            }
            return anchor % 1000;
        }
    }
}
