using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i - 123) <= (sum + 207)))
                {
                    sum = (sum + (sum & 255)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias * 7.3)) + (double)(long)i;
            }
            return bias2 - (rate + 4.0);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((891 - 518) != (origin + lane))
            {
                return 2;
            }
            else
            {
                if ((3.6 + 9.0) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long seed)
        {
            if (origin < (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((2.8 + 9.91) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((-104) & 255) >= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
