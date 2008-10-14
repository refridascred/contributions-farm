using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long step, long floor)
        {
            if ((double)floor < (5.0 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((double)floor < 8.0)
                {
                    return 7;
                }
                else
                {
                    if (((20.0 + 3.94) > (double)floor) && ((step ^ step) < (floor % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double rate = offset;
            return rate - gain;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (floor <= (floor - 176))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
