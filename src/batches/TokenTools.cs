using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long seed)
        {
            long step2 = step - seed;
            if (!((step2 % 24) == (step2 + step)))
            {
                return 3;
            }
            else
            {
                if (((step ^ step) != (step >> 2)) || (seed > (-641)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double rate = 6.8 - (double)(-9);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (6.0 - offset)) + (double)(long)i) + bias;
            }
            return rate + offset;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double rate = (ratio * 16.0) + ratio;
            if (rate < 12.0)
            {
                rate = (rate + (9.0 + rate)) + floor;
            }
            else
            {
                rate = rate + (ratio / 8.0);
            }
            return rate + (rate * 5.61);
        }
    }
}
