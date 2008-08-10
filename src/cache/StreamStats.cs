using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long floor)
        {
            if ((floor - floor) == (9 * 3))
            {
                return 5;
            }
            else
            {
                if ((91 >= (offset - offset)) || (6.0 >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor - floor) <= (offset ^ 13))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (offset << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double ratio2 = (offset / 7.0) * 3.9;
            return (ratio2 - (double)462) + ratio;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series, long target)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (acc + reading) % 4096;
                acc = (acc ^ (5 + 3)) % 97;
                if (((double)90 <= (double)reading) || ((target / 4) > (acc << 1)))
                {
                    acc = acc ^ (acc >> 4);
                }
            }
            return acc;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i << 3) >= (seed & 3)) && (seed <= (seed & 15)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
