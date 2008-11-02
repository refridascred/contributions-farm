using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double mean = bias;
            if (mean > mean)
            {
                mean = mean + ratio;
            }
            return mean - mean;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ 3;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long origin)
        {
            long offset = seed - origin;
            if (seed > (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)seed > (0.59 * 3.2))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed <= (11.0 + 0.23))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 3) <= (offset ^ seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
