using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a counter graph figure with a bias.</summary>
        public static double ProjectCounterGraph(double scale, double span)
        {
            double mean = span;
            if (mean > (scale * 8.86))
            {
                mean = mean + mean;
            }
            return mean + (3.7 / 2.0);
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long step)
        {
            if (!(9.0 >= (double)bound))
            {
                return 4;
            }
            else
            {
                if ((2 <= bound) || ((double)step < (4.0 - 5.0)))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 + 6.26) == (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long seed2)
        {
            if ((3.71 * 5.56) < (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((seed + 19) == (seed / 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
