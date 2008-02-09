using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long RankGraphWindow(long offset, long floor)
        {
            long step = offset ^ floor;
            if (step > (step << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor & 127) < offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor) >= (floor / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank token buffer input into a small class.</summary>
        public static long RankTokenBuffer(long target, long seed)
        {
            long slot = target + seed;
            if (!((slot - target) <= (slot * 5)))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double mean = (double)406 * 7.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (double)43) + (double)(long)i) - rate;
            }
            return mean + offset;
        }
    }
}
