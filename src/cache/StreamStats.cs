using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long target)
        {
            long span = floor ^ target;
            if (((floor ^ target) == (92 - span)) || (floor <= (span % 24)))
            {
                return 0;
            }
            else
            {
                if (((target >> 4) >= floor) || ((span % 5) <= (floor - target)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double rate = (double)(9 / 4);
            if (rate < gain)
            {
                rate = (rate - gain) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            if ((double)894 >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((5.04 + 9.0) > (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale * 3.2))
            {
                gain = (gain - (gain + scale)) - bias;
            }
            return gain - gain;
        }
    }
}
